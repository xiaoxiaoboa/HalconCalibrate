using System.ComponentModel;
using System.Globalization;
using HalconCalibration.Enums;

namespace HalconCalibration.Views.HalconProjects;

/***
 *  此类作为模板类使用
 *  非必要不修改
 *  使用时复制一份再使用
 */

[ToolboxItem(false)]
public partial class MeasureDimensions : UserControl
{
    private double ThresholdMin { get; set; } = 125.0;
    private double ThresholdMax { get; set; } = 255.0;
    private double SelectShapeMin { get; set; } = 150;
    private double SelectShapeMax { get; set; } = 9999;

    private string Feature { get; set; } = nameof(SelectShapeFeatures.area);
    private string Operator { get; set; } = nameof(SelectShapeOperation.and);
    public MeasureDimensions()
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
    
    private void MeasureDimensions_Load(object sender, EventArgs e)
    {
        // 控制控件宽度
        tableLayoutPanel1.Width = (int)(panel3.Width * 0.95);
    }

    private void applyBtn_Click(object sender, EventArgs e)
    {

    }

    private void resetBtn_Click(object sender, EventArgs e)
    {

    }

    private void thresholdMin_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse((string?)thresholdMin.Text, out double result))
        {
            ThresholdMin = result;
        }
    }

    private void thresholdMax_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse((string?)thresholdMax.Text, out double result))
        {
            ThresholdMax = result;
        }
    }

    private void selectShapeMin_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse((string?)selectShapeMin.Text, out double result))
        {
            SelectShapeMin = result;
        }
    }

    private void selectShapeMax_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse((string?)selectShapeMax.Text, out double result))
        {
            SelectShapeMax = result;
        }
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