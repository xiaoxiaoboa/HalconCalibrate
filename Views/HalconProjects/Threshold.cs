using System.Globalization;
using HalconCalibration.Common;
using HalconCalibration.Enums;
using HalconDotNet;

namespace HalconCalibration.Views.HalconProjects;

public partial class Threshold : Form {
    private HWindow? _window;


    public Threshold(HWindow hWindow) {
        InitializeComponent();

        _window = hWindow;

        featuresComboBox.DataSource = Enum.GetNames(typeof(SelectShapeFeatures));
        operatorComboBox.DataSource = Enum.GetNames(typeof(SelectShapeOperation));
        featuresComboBox.SelectedItem = nameof(SelectShapeFeatures.area);
        operatorComboBox.SelectedItem = nameof(SelectShapeOperation.and);

        thresholdMin.Text = ThresholdCtrl.Instance.ThresholdMin.ToString(CultureInfo.CurrentCulture);
        thresholdMax.Text = ThresholdCtrl.Instance.ThresholdMax.ToString(CultureInfo.CurrentCulture);

        selectShapeMin.Text = ThresholdCtrl.Instance.SelectShapeMin.ToString(CultureInfo.CurrentCulture);
        selectShapeMax.Text = ThresholdCtrl.Instance.SelectShapeMax.ToString(CultureInfo.CurrentCulture);
    }

    // 恢复控件到UI线程执行
    private void RunOnUIThread(Action action) {
        if (InvokeRequired) {
            Invoke(action);
        }
        else {
            action();
        }
    }

    // 阈值分割
    public (HTuple, HTuple) HandleThreshold() {
        try {
            if (CameraCtrl.Instance.Image == null) throw new Exception("图像未加载");

            // 转灰度图
            HImage grayImage = CameraCtrl.Instance.Image.Rgb1ToGray();
            // 阈值分割
            HRegion thresholdRegion =
                grayImage.Threshold(ThresholdCtrl.Instance.ThresholdMin, ThresholdCtrl.Instance.ThresholdMax);
            // 连通
            HRegion connectionRegion = thresholdRegion.Connection();
            // 形状过滤
            HRegion selectRegion = connectionRegion.SelectShape(ThresholdCtrl.Instance.Feature,
                ThresholdCtrl.Instance.Operator, ThresholdCtrl.Instance.SelectShapeMin,
                ThresholdCtrl.Instance.SelectShapeMax);
            // 中心点和面积
            ThresholdCtrl.Instance.Area = selectRegion.AreaCenter(out HTuple row, out HTuple column);
            ThresholdCtrl.Instance.RegionValue = selectRegion;


            // 图像加载到控件
            _window?.ClearWindow();
            grayImage.DispObj(_window);
            selectRegion.DispObj(_window);
            return (row, column);
        }
        catch (Exception exception) {
            RunOnUIThread(() => Logger.Instance.AddLog($"图像处理操作失败：{exception.Message}", LogLevel.Error));
            MessageBox.Show($@"图像处理操作失败：{exception.Message}");
        }

        return (new HTuple(), new HTuple());
    }

    // 应用
    private void applyBtn_Click(object sender, EventArgs e) {
        HandleThreshold();
    }

    private void resetBtn_Click(object sender, EventArgs e) {
        ThresholdCtrl.Instance.ThresholdMin = 125.0;
        ThresholdCtrl.Instance.ThresholdMax = 255.0;
        ThresholdCtrl.Instance.SelectShapeMin = 150;
        ThresholdCtrl.Instance.SelectShapeMax = 9999;
        ThresholdCtrl.Instance.Feature = nameof(SelectShapeFeatures.area);
        ThresholdCtrl.Instance.Operator = nameof(SelectShapeOperation.and);

        thresholdMin.Text = ThresholdCtrl.Instance.ThresholdMin.ToString(CultureInfo.CurrentCulture);
        thresholdMax.Text = ThresholdCtrl.Instance.ThresholdMax.ToString(CultureInfo.CurrentCulture);
        selectShapeMin.Text = ThresholdCtrl.Instance.SelectShapeMin.ToString(CultureInfo.CurrentCulture);
        selectShapeMax.Text = ThresholdCtrl.Instance.SelectShapeMax.ToString(CultureInfo.CurrentCulture);
    }

    private void featuresComboBox_SelectionChangeCommitted(object sender, EventArgs e) {
        var item = featuresComboBox.SelectedItem;
        if (item is string s) {
            ThresholdCtrl.Instance.Feature = s;
        }
        else {
            MessageBox.Show(@"选择项时出错！");
        }
    }


    private void operatorComboBox_SelectionChangeCommitted(object sender, EventArgs e) {
        var item = operatorComboBox.SelectedItem;
        if (item is string s) {
            ThresholdCtrl.Instance.Operator = s;
        }
        else {
            MessageBox.Show(@"选择项时出错！");
        }
    }

    private void thresholdMin_TextChanged(object sender, EventArgs e) {
        if (double.TryParse(thresholdMin.Text, out double result)) {
            ThresholdCtrl.Instance.ThresholdMin = result;
        }
    }

    private void thresholdMax_TextChanged(object sender, EventArgs e) {
        if (double.TryParse(thresholdMax.Text, out double result)) {
            ThresholdCtrl.Instance.ThresholdMax = result;
        }
    }

    private void selectShapeMin_TextChanged(object sender, EventArgs e) {
        if (double.TryParse(selectShapeMin.Text, out double result)) {
            ThresholdCtrl.Instance.SelectShapeMin = result;
        }
    }

    private void selectShapeMax_TextChanged(object sender, EventArgs e) {
        if (double.TryParse(selectShapeMax.Text, out double result)) {
            ThresholdCtrl.Instance.SelectShapeMax = result;
        }
    }
}