using System;
using System.ComponentModel;
using System.Globalization;
using HalconCalibration.Common;
using HalconCalibration.Enums;
using HalconDotNet;

namespace HalconCalibration.Views.HalconProjects;

[ToolboxItem(false)]
public partial class Calibration : UserControl
{
    private HWindow _window;

    // private HImage _image = new("C:\\Users\\zxiao\\Desktop\\halcon_dump.bmp");
    private double ThresholdMin { get; set; } = 125.0;
    private double ThresholdMax { get; set; } = 255.0;
    private double SelectShapeMin { get; set; } = 150;
    private double SelectShapeMax { get; set; } = 9999;

    private string Feature { get; set; } = nameof(SelectShapeFeatures.area);
    private string Operator { get; set; } = nameof(SelectShapeOperation.and);

    public Calibration(HWindow hWindow)
    {
        InitializeComponent();

        _window = hWindow;
        // _image.DispObj(_window);

        featuresComboBox.DataSource = Enum.GetNames(typeof(SelectShapeFeatures));
        operatorComboBox.DataSource = Enum.GetNames(typeof(SelectShapeOperation));
        featuresComboBox.SelectedItem = nameof(SelectShapeFeatures.area);
        operatorComboBox.SelectedItem = nameof(SelectShapeOperation.and);

        thresholdMin.Text = ThresholdMin.ToString(CultureInfo.CurrentCulture);
        thresholdMax.Text = ThresholdMax.ToString(CultureInfo.CurrentCulture);

        selectShapeMin.Text = SelectShapeMin.ToString(CultureInfo.CurrentCulture);
        selectShapeMax.Text = SelectShapeMax.ToString(CultureInfo.CurrentCulture);

        CameraCtrl.Instance.CapturedCompleted += OnCaptured;
    }

    // 拍照成功后执行
    private void OnCaptured(object? sender, EventArgs e)
    {
        try
        {
            if (CameraCtrl.Instance.Image == null) return;

            HImage grayImage = CameraCtrl.Instance.Image.Rgb1ToGray();
            HRegion thresholdRegion = grayImage.Threshold(ThresholdMin, ThresholdMax);
            HRegion connectionRegion = thresholdRegion.Connection();
            HRegion selectRegion = connectionRegion.SelectShape(Feature, Operator, SelectShapeMin, SelectShapeMax);
            HTuple area = selectRegion.AreaCenter(out HTuple row, out HTuple column);

            _window.ClearWindow();
            grayImage.DispObj(_window);
            selectRegion.DispObj(_window);

            Logger.Instance.AddLog("图像处理完成");
        }
        catch (Exception exception)
        {
            Logger.Instance.AddLog(exception.Message);
            MessageBox.Show(exception.Message);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        OnCaptured(sender, e);
    }

    private void button2_Click(object sender, EventArgs e)
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