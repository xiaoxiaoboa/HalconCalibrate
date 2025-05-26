using System;
using System.ComponentModel;
using System.Globalization;
using HalconCalibration.Enums;
using HalconDotNet;

namespace HalconCalibration.Views.HalconProjects;

[ToolboxItem(false)]
public partial class Calibration : UserControl
{
    private HImage _image = new("C:\\Users\\zxiao\\Desktop\\halcon_dump.bmp");
    private double ThresholdMin { get; set; } = 125.0;
    private double ThresholdMax { get; set; } = 255.0;
    private double SelectShapeMin { get; set; } = 150;
    private double SelectShapeMax { get; set; } = 9999;

    private string Feature { get; set; } = nameof(SelectShapeFeatures.area);
    private string Operator { get; set; } = nameof(SelectShapeOperation.and);

    public Calibration()
    {
        InitializeComponent();

        featuresComboBox.DataSource = Enum.GetNames(typeof(SelectShapeFeatures));
        operatorComboBox.DataSource = Enum.GetNames(typeof(SelectShapeOperation));
        featuresComboBox.SelectedItem = nameof(SelectShapeFeatures.area);
        operatorComboBox.SelectedItem = nameof(SelectShapeOperation.and);

        thresholdMin.Text = ThresholdMin.ToString(CultureInfo.CurrentCulture);
        thresholdMax.Text = ThresholdMax.ToString(CultureInfo.CurrentCulture);

        selectShapeMin.Text = SelectShapeMin.ToString(CultureInfo.CurrentCulture);
        selectShapeMax.Text = SelectShapeMax.ToString(CultureInfo.CurrentCulture);
    }


    // TODO 拍照后运行一下
    public void Run()
    {
        //_image.Rgb1ToGray();
        //HRegion thresholdRegion = _image.Threshold(ThresholdMin, ThresholdMax);
        //HRegion connectionRegion = thresholdRegion.Connection();
        //HRegion selectRegion = connectionRegion.SelectShape(Feature, Operator, SelectShapeMin, SelectShapeMax);
        //HTuple area = selectRegion.AreaCenter(out HTuple row, out HTuple column);

        //MessageBox.Show($@"area:{area},row:{row},col:{column}");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Run();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        ThresholdMin = 125.0;
        ThresholdMax = 255.0;
        SelectShapeMin = 150;
        SelectShapeMax = 9999;
        Feature = nameof(SelectShapeFeatures.area);
        Operator = nameof(SelectShapeOperation.and);
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
}