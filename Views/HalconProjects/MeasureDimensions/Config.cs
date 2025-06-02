using System.Globalization;
using HalconCalibration.Common;
using HalconCalibration.Enums;
using HalconDotNet;

namespace HalconCalibration.Views.HalconProjects.MeasureDimensions;

public partial class Config : Form
{
    private HWindow? _window;
    private string InterpolationValue { get; set; } = nameof(Interpolation.nearest_neighbor);
    private double Sigma { get; set; } = 1;
    private int Threshold { get; set; } = 30;
    private string TransitionValue { get; set; } = nameof(Transition.all);
    private string SelectValue { get; set; } = nameof(Enums.Select.all);
    


    public Config(HWindow? hWindow)
    {
        InitializeComponent();
        _window = hWindow;


        interpolationCombobox.DataSource = Enum.GetNames(typeof(Interpolation));
        transitionCombobx.DataSource = Enum.GetNames(typeof(Transition));
        selectCombobox.DataSource = Enum.GetNames(typeof(Select));

        interpolationCombobox.Text = InterpolationValue;
        transitionCombobx.Text = TransitionValue;
        selectCombobox.Text = SelectValue;
        sigma.Text = Sigma.ToString(CultureInfo.CurrentCulture);
        threshold.Text = Threshold.ToString();

    }

    // 测量算法
    public void Measure(double extraAngle, double extraLength1, double extraLength2)
    {
        if (CameraCtrl.Instance.Image == null) throw new Exception("图像未加载");

        // 需要创建一个新region，不然每次执行，region会被GenContourPolygonXld修改
        HRegion hr = new HRegion(ThresholdCtrl.Instance.RegionValue);

        // HImage image = CameraCtrl.Instance.Image.Rgb1ToGray();
        // image.GetImageSize(out HTuple width, out HTuple height);

        // if (ThresholdCtrl.Instance.RegionValue == null) return;
        // 生成最小外接矩形
        hr.SmallestRectangle2(out HTuple row, out HTuple column, out HTuple phi, out HTuple length1,
            out HTuple length2);

        // 点位
        var topX = row - length2;
        var bottomX = row + length2;
        var leftY = column - length1;
        var rightY = column + length1;

        // 仿射像素坐标得到机械坐标
        HTuple realLeftX = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(row, leftY, out HTuple realLeftY);
        HTuple realRightX = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(row, rightY, out HTuple realRightY);
        HTuple realTopX = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(topX, column, out HTuple realTopY);
        HTuple realBottomX = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(bottomX, column, out HTuple realBottomY);

        var disX = HMisc.DistancePp(realLeftX, realLeftY, realRightX, realRightY);
        var disY = HMisc.DistancePp(realTopX, realTopY, realBottomX, realBottomY);

        // var disX = HMisc.DistancePp(row, leftY, row, rightY);
        // var disY = HMisc.DistancePp(topX, column, bottomX, column);

        // 存储边缘对
        HXLDCont leftPair = new HXLDCont();
        HXLDCont rightPair = new HXLDCont();
        HXLDCont topPair = new HXLDCont();
        HXLDCont bottomPair = new HXLDCont();

        // 生成边缘对线
        // 左侧
        leftPair.GenContourPolygonXld(new HTuple(new double[] { row + disY * 0.4, row - disY * 0.4 }),
            new HTuple(new double[] { leftY, leftY }));
        // 右侧
        rightPair.GenContourPolygonXld(new HTuple(new double[] { row + disY * 0.4, row - disY * 0.4 }),
            new HTuple(new double[] { rightY, rightY }));

        // 上侧
        topPair.GenContourPolygonXld(new HTuple(new double[] { topX, topX }),
            new HTuple(new double[] { column + disX * 0.4, column - disX * 0.4 }));

        // 下侧
        bottomPair.GenContourPolygonXld(new HTuple(new double[] { bottomX, bottomX }),
            new HTuple(new double[] { column + disX * 0.4, column - disX * 0.4 }));

        _window?.ClearWindow();
        CameraCtrl.Instance.Image.DispObj(_window);
        leftPair.DispObj(_window);
        rightPair.DispObj(_window);
        topPair.DispObj(_window);
        bottomPair.DispObj(_window);
        Logger.Instance.AddLog($"X轴方向宽度：{disX}，Y轴方向宽度：{disY}");
        // // 计算弧度
        // HTuple radian = (extraAngle + phi) * Math.PI / 180;
        // // 生成矩形
        // hr.GenRectangle2(row, column, phi, length1 * extraLength1, length2 * extraLength2);
        //
        // // 生成测量矩形
        // HMeasure hm = new HMeasure();
        // hm.GenMeasureRectangle2(row, column, radian, length1 * extraLength1, length2 * extraLength2, width, height,
        //     InterpolationValue);
        //
        // // 生成点位数据
        // hm.MeasurePairs(image, Sigma, Threshold, TransitionValue, SelectValue, out HTuple rowEdgeFirst,
        //     out HTuple columnEdgeFirst, out HTuple amplitudeFirst, out HTuple rowEdgeSecond,
        //     out HTuple columnEdgeSecond, out HTuple amplitudeSecond, out HTuple intraDistance,
        //     out HTuple interDistance);
        //
        // // 转换真实点位坐标
        // HTuple qx1 = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(rowEdgeFirst, columnEdgeFirst, out HTuple qy1);
        // HTuple qx2 = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(rowEdgeSecond, columnEdgeSecond, out HTuple qy2);
        // // 计算
        // for (int i = 0; i < qx1.Length; i++) {
        //     var dis = HMisc.DistancePp(qx1[i].D, qy1[i].D, qx2[i].D, qy2[i].D);
        // }


        // 先清理一下窗口，为了显示边缘对
        // _window?.ClearWindow();
        // _window?.SetDraw("margin");
        // _window?.SetLineWidth(3);
        // CameraCtrl.Instance.Image.DispObj(_window);

        // 生成边缘对
        // GenEdgePair(rowEdgeFirst.Length, rowEdgeFirst, columnEdgeFirst, radian, length2);
        // GenEdgePair(rowEdgeSecond.Length, rowEdgeSecond, columnEdgeSecond, radian, length2);
    }

    // 生成边缘对算法
    private void GenEdgePair(int count, HTuple rowEdge, HTuple columnEdge, HTuple radian, double radius)
    {
        for (int i = 0; i < count; i++)
        {
            double rowStart = rowEdge[i] + radius * Math.Cos(radian);
            double rowEnd = rowEdge[i] - radius * Math.Cos(radian);
            double columnStart = columnEdge[i] + radius * Math.Sin(radian);
            double columnEnd = columnEdge[i] - radius * Math.Sin(radian);


            HXLDCont hd = new HXLDCont();
            HTuple rows = new HTuple();
            HTuple cols = new HTuple();

            rows.Append(rowStart);
            rows.Append(rowEnd);
            cols.Append(columnStart);
            cols.Append(columnEnd);


            hd.GenContourPolygonXld(rows, cols);

            hd.DispObj(_window);
        }
    }

    // 运行算法
    private void applyBtn_Click(object sender, EventArgs e)
    {
        Measure(0, 0, 0);
        // if (RadioX) {
        //     // X轴方向测量
        //     Measure(0, 1.5, 0.5);
        // }
        //
        // if (RadioY) {
        //     // Y轴方向测量 
        //     Measure(90, 1.5, 0.5);
        // }
    }

    private void resetBtn_Click(object sender, EventArgs e) { }


    private void sigma_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse(sigma.Text, out double result))
        {
            Sigma = result;
        }
    }

    private void threshold_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(threshold.Text, out int result))
        {
            Threshold = result;
        }
    }

    private void interpolationCombobox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var item = interpolationCombobox.SelectedItem;
        if (item is string s)
        {
            InterpolationValue = s;
        }
        else
        {
            MessageBox.Show(@"选择项时出错！");
        }
    }

    private void transitionCombobx_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var item = transitionCombobx.SelectedItem;
        if (item is string s)
        {
            TransitionValue = s;
        }
        else
        {
            MessageBox.Show(@"选择项时出错！");
        }
    }

    private void selectCombobox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var item = selectCombobox.SelectedItem;
        if (item is string s)
        {
            SelectValue = s;
        }
        else
        {
            MessageBox.Show(@"选择项时出错！");
        }
    }

}