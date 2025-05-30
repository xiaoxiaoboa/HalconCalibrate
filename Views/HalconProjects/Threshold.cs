using System.Globalization;
using HalconCalibration.Common;
using HalconCalibration.Enums;
using HalconDotNet;

namespace HalconCalibration.Views.HalconProjects;

public partial class Threshold : Form
{
    private HWindow? _window;

    private double ThresholdMin { get; set; } = 125.0;
    private double ThresholdMax { get; set; } = 255.0;
    private double SelectShapeMin { get; set; } = 150;
    private double SelectShapeMax { get; set; } = 9999;

    private string Feature { get; set; } = nameof(SelectShapeFeatures.area);
    private string Operator { get; set; } = nameof(SelectShapeOperation.and);

    private HRegion? _hRegion;

    public HRegion? SelectRegion
    {
        get => _hRegion;
        private set => _hRegion = value;
    }


    public Threshold(HWindow hWindow)
    {
        InitializeComponent();

        _window = hWindow;

        featuresComboBox.DataSource = Enum.GetNames(typeof(SelectShapeFeatures));
        operatorComboBox.DataSource = Enum.GetNames(typeof(SelectShapeOperation));
        featuresComboBox.SelectedItem = nameof(SelectShapeFeatures.area);
        operatorComboBox.SelectedItem = nameof(SelectShapeOperation.and);

        thresholdMin.Text = ThresholdMin.ToString(CultureInfo.CurrentCulture);
        thresholdMax.Text = ThresholdMax.ToString(CultureInfo.CurrentCulture);

        selectShapeMin.Text = SelectShapeMin.ToString(CultureInfo.CurrentCulture);
        selectShapeMax.Text = SelectShapeMax.ToString(CultureInfo.CurrentCulture);
    }

    // 恢复控件到UI线程执行
    private void RunOnUIThread(Action action)
    {
        if (InvokeRequired)
        {
            Invoke(action);
        }
        else
        {
            action();
        }
    }

    // 阈值分割
    public (HTuple, HTuple) HandleThreshold()
    {
        try
        {
            if (CameraCtrl.Instance.Image == null) throw new Exception("图像未加载");
            HImage grayImage = CameraCtrl.Instance.Image.Rgb1ToGray();
            HRegion thresholdRegion = grayImage.Threshold(ThresholdMin, ThresholdMax);
            HRegion connectionRegion = thresholdRegion.Connection();
            HRegion selectRegion = connectionRegion.SelectShape(Feature, Operator, SelectShapeMin, SelectShapeMax);
            selectRegion.AreaCenter(out HTuple row, out HTuple column);

            SelectRegion = selectRegion;

            // 图像加载到控件
            _window?.ClearWindow();
            grayImage.DispObj(_window);
            selectRegion.DispObj(_window);
            return (row, column);
        }
        catch (Exception exception)
        {
            RunOnUIThread(() => Logger.Instance.AddLog($"图像处理操作失败：{exception.Message}", LogLevel.Error));
            MessageBox.Show($@"图像处理操作失败：{exception.Message}");
        }

        return (new HTuple(), new HTuple());
    }

    // 应用
    private void applyBtn_Click(object sender, EventArgs e)
    {
        HandleThreshold();
    }

    private void resetBtn_Click(object sender, EventArgs e)
    {
        ThresholdMin = 125.0;
        ThresholdMax = 255.0;
        SelectShapeMin = 150;
        SelectShapeMax = 9999;
        Feature = nameof(SelectShapeFeatures.area);
        Operator = nameof(SelectShapeOperation.and);

        thresholdMin.Text = ThresholdMin.ToString(CultureInfo.CurrentCulture);
        thresholdMax.Text = ThresholdMax.ToString(CultureInfo.CurrentCulture);
        selectShapeMin.Text = SelectShapeMin.ToString(CultureInfo.CurrentCulture);
        selectShapeMax.Text = SelectShapeMax.ToString(CultureInfo.CurrentCulture);
    }

    private void featuresComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var item = featuresComboBox.SelectedItem;
        if (item is string s)
        {
            Feature = s;
        }
        else
        {
            MessageBox.Show(@"选择项时出错！");
        }
    }


    private void operatorComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var item = operatorComboBox.SelectedItem;
        if (item is string s)
        {
            Operator = s;
        }
        else
        {
            MessageBox.Show(@"选择项时出错！");
        }
    }

    private void thresholdMin_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse(thresholdMin.Text, out double result))
        {
            ThresholdMin = result;
        }
    }

    private void thresholdMax_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse(thresholdMax.Text, out double result))
        {
            ThresholdMax = result;
        }
    }

    private void selectShapeMin_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse(selectShapeMin.Text, out double result))
        {
            SelectShapeMin = result;
        }
    }

    private void selectShapeMax_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse(selectShapeMax.Text, out double result))
        {
            SelectShapeMax = result;
        }
    }
}