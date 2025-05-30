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

    private HRegion? _selectRegion;

    public Config(HWindow hWindow, HRegion region)
    {
        InitializeComponent();
        _window = hWindow;
        _selectRegion = region;

        interpolationCombobox.DataSource = Enum.GetNames(typeof(Interpolation));
        transitionCombobx.DataSource = Enum.GetNames(typeof(Transition));
        selectCombobox.DataSource = Enum.GetNames(typeof(Select));

        interpolationCombobox.Text = InterpolationValue;
        transitionCombobx.Text = TransitionValue;
        selectCombobox.Text = SelectValue;
        sigma.Text = Sigma.ToString(CultureInfo.CurrentCulture);
        threshold.Text = Threshold.ToString();
    }

    public void Measure(double extraAngle, double extraLength1, double extraLength2)
    {
        if (CameraCtrl.Instance.Image == null) throw new Exception("图像未加载");

        // 需要创建一个新region，不然每次执行，region会被GenContourPolygonXld修改
        HRegion hr = new HRegion(_selectRegion);

        HImage image = CameraCtrl.Instance.Image.Rgb1ToGray();
        image.GetImageSize(out HTuple width, out HTuple height);

        if (_selectRegion == null) return;
        // 生成最小外接矩形
        hr.SmallestRectangle2(out HTuple row, out HTuple column, out HTuple phi, out HTuple length1,
            out HTuple length2);
        // 计算弧度
        HTuple radian = (extraAngle + phi) * Math.PI / 180;
        // 生成矩形
        hr.GenRectangle2(row, column, phi, length1 * extraLength1, length2 * extraLength2);

        // 生成测量矩形
        HMeasure hm = new HMeasure();
        hm.GenMeasureRectangle2(row, column, radian, length1 * extraLength1, length2 * extraLength2, width, height,
            InterpolationValue);

        // 生成点位数据
        hm.MeasurePairs(image, Sigma, Threshold, TransitionValue, SelectValue, out HTuple rowEdgeFirst,
            out HTuple columnEdgeFirst, out HTuple amplitudeFirst, out HTuple rowEdgeSecond,
            out HTuple columnEdgeSecond, out HTuple amplitudeSecond, out HTuple intraDistance,
            out HTuple interDistance);

        // 转换真实点位坐标
        HTuple qx1 = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(rowEdgeFirst, columnEdgeFirst, out HTuple qy1);
        HTuple qx2 = CameraCtrl.Instance.HomMat2D.AffineTransPoint2d(rowEdgeSecond, columnEdgeSecond, out HTuple qy2);
        // 计算
        for (int i = 0; i < qx1.Length; i++)
        {
            Logger.Instance.AddLog($"x1:{qx1[i].D}, y1:{qy1[i].D}, x2:{qx2[i].D}, y2:{qy2[i].D}");
            var dis = HMisc.DistancePp(qx1[i].D, qy1[i].D, qx2[i].D, qy2[i].D);
            Logger.Instance.AddLog($"第{i + 1}组尺寸：{dis}");
        }


        // 先清理一下窗口，为了显示边缘对
        _window?.ClearWindow();
        _window?.SetDraw("margin");
        _window?.SetLineWidth(3);
        CameraCtrl.Instance.Image.DispObj(_window);

        // 生成边缘对
        GenEdgePair(rowEdgeFirst.Length, rowEdgeFirst, columnEdgeFirst, radian, length2);
        GenEdgePair(rowEdgeSecond.Length, rowEdgeSecond, columnEdgeSecond, radian, length2);
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

    private void applyBtn_Click(object sender, EventArgs e)
    {
        Measure(90, 1.5, 0.5);
        Measure(0,1.5,0.5);
    }

    private void resetBtn_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }


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