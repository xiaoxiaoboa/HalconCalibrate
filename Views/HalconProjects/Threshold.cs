using System.Globalization;
using HalconCalibration.Common;
using HalconCalibration.Enums;
using HalconDotNet;

namespace HalconCalibration.Views.HalconProjects;

public partial class Threshold : Form {
    private HWindow? _window;


    public Threshold(HWindow? hWindow) {
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

    // 应用
    private void applyBtn_Click(object sender, EventArgs e) {
        if (!ThresholdCtrl.Instance.HandleThreshold(_window, out var msg)) {
            Logger.Instance.AddLog($"阈值分割失败请重试：{msg}");
            MessageBox.Show(@$"阈值分割失败请重试：{msg}");
        }
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