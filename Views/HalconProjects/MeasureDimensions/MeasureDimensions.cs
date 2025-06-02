using System.ComponentModel;
using HalconCalibration.Common;
using HalconDotNet;

namespace HalconCalibration.Views.HalconProjects.MeasureDimensions;

[ToolboxItem(false)]
public partial class MeasureDimensions : UserControl {
    private HWindow? _window;

    // 窗口
    private Threshold? _threshold;
    private Config? _config;


    public MeasureDimensions(HWindow hWindow) {
        _window = hWindow;
        InitializeComponent();

        Disposed += FormClosing;
    }

    private void Measure() {
        if (CameraCtrl.Instance.Image == null) {
            MessageBox.Show(@"图像未加载");
            return;
        }

        // 需要创建一个新region，不然每次执行，region会被GenContourPolygonXld修改
        HRegion hr = new HRegion(ThresholdCtrl.Instance.RegionValue);

        // 生成最小外接矩形
        hr.SmallestRectangle2(out HTuple row, out HTuple column, out HTuple phi, out HTuple length1,
            out HTuple length2);


        // 点位
        var topX = row - length2 * Math.Cos(phi);
        var topY = column - length2 * Math.Sin(phi);
        
        var bottomX = row + length2 * Math.Cos(phi);
        var bottomY = column + length2 * Math.Sin(phi);
        
        var leftX = row + length1 * Math.Sin(phi);
        var leftY = column - length1 * Math.Cos(phi);
        
        var rightX = row - length1 * Math.Sin(phi);
        var rightY = column + length1 * Math.Cos(phi);

        // 仿射像素坐标得到机械坐标
        HTuple realLeftX = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(leftX, leftY, out HTuple realLeftY);
        HTuple realRightX = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(rightX, rightY, out HTuple realRightY);
        HTuple realTopX = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(topX, topY, out HTuple realTopY);
        HTuple realBottomX = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(bottomX, bottomY, out HTuple realBottomY);

        var disX = HMisc.DistancePp(realLeftX, realLeftY, realRightX, realRightY);
        var disY = HMisc.DistancePp(realTopX, realTopY, realBottomX, realBottomY);


        // 存储边缘对
        HXLDCont leftPair = new HXLDCont();
        HXLDCont rightPair = new HXLDCont();
        HXLDCont topPair = new HXLDCont();
        HXLDCont bottomPair = new HXLDCont();


        // 生成边缘对线
        // 左侧
        leftPair.GenContourPolygonXld(
            new HTuple(new double[] { leftX + length2 * 0.4 * Math.Cos(phi), leftX - length2 * 0.4 * Math.Cos(phi) }),
            new HTuple(new double[] { leftY + length2 * 0.4 * Math.Sin(phi), leftY - length2 * 0.4 * Math.Sin(phi) }));
        // 右侧
        rightPair.GenContourPolygonXld(
            new HTuple(new double[] { rightX + length2 * 0.4 * Math.Cos(phi), rightX - length2 * 0.4 * Math.Cos(phi) }),
            new HTuple(new double[]
                { rightY + length2 * 0.4 * Math.Sin(phi), rightY - length2 * 0.4 * Math.Sin(phi) }));

        // 上侧
        topPair.GenContourPolygonXld(
            new HTuple(new double[] { topX - length1 * 0.4 * Math.Sin(phi), topX + length1 * 0.4 * Math.Sin(phi) }),
            new HTuple(new double[] { topY + length1 * 0.4 * Math.Cos(phi), topY - length1 * 0.4 * Math.Cos(phi) }));
        
        // 下侧
        bottomPair.GenContourPolygonXld(
            new HTuple(new double[]
                { bottomX - length1 * 0.4 * Math.Sin(phi), bottomX + length1 * 0.4 * Math.Sin(phi) }),
            new HTuple(new double[]
                { bottomY + length1 * 0.4 * Math.Cos(phi), bottomY - length1 * 0.4 * Math.Cos(phi) }));

        // 显示
        _window?.ClearWindow();
        _window?.SetDraw("margin");
        _window?.SetLineWidth(3);
        CameraCtrl.Instance.Image.DispObj(_window);
        _window?.SetColor("red");
        // hr.DispObj(_window);
        leftPair.DispObj(_window);
        rightPair.DispObj(_window);
        topPair.DispObj(_window);
        bottomPair.DispObj(_window);
        Logger.Instance.AddLog($"X轴方向尺寸：{disX}，Y轴方向尺寸：{disY}");
    }

    // 打开阈值分割窗口
    private void threshold_Click(object sender, EventArgs e) {
        if (_threshold == null || _threshold.IsDisposed) {
            _threshold = new Threshold(_window);
            _threshold.Show();
        }
        else {
            _threshold.Close();
        }
    }

    // 开始测量
    private void measure_Click(object sender, EventArgs e) {
        Measure();
    }

    private void FormClosing(object? sender, EventArgs e) {
        _threshold?.Dispose();
    }
}