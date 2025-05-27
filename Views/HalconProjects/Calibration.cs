using System;
using System.ComponentModel;
using System.Globalization;
using HalconCalibration.Common;
using HalconCalibration.Enums;
using HalconDotNet;
using S7.Net;

namespace HalconCalibration.Views.HalconProjects;

[ToolboxItem(false)]
public partial class Calibration : UserControl
{
    private HWindow _window;
    
    private double ThresholdMin { get; set; } = 125.0;
    private double ThresholdMax { get; set; } = 255.0;
    private double SelectShapeMin { get; set; } = 150;
    private double SelectShapeMax { get; set; } = 9999;

    private string Feature { get; set; } = nameof(SelectShapeFeatures.area);
    private string Operator { get; set; } = nameof(SelectShapeOperation.and);

    private readonly HTuple _pixelRow = new();
    private readonly HTuple _pixelColumn = new();

    private readonly HTuple _realRow = new();
    private readonly HTuple _realColumn = new();


    public Calibration(HWindow hWindow)
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
            selectRegion.AreaCenter(out HTuple row, out HTuple column);

            // 图像加载到控件
            _window.ClearWindow();
            grayImage.DispObj(_window);
            selectRegion.DispObj(_window);
            


            // 保存像素坐标
            _pixelRow.Append(row);
            _pixelColumn.Append(column);

            RunOnUIThread(() => Logger.Instance.AddLog($"圆点，row：{row}，column：{column}"));


            if (PlcControl.Instance.NineCaliNum == 9)
            {
                // 点对仿射
                CameraCtrl.Instance.HomMat2D.VectorToHomMat2d(_pixelRow, _pixelColumn, _realRow, _realColumn);
                // 停止监听
                PlcControl.Instance.StopListener();

                Logger.Instance.AddLog("九点标定完成，仿射关系已保存");
                // 恢复默认
                PlcControl.Instance.NineCaliNum = 0;
            }
        }
        catch (Exception exception)
        {
            Logger.Instance.AddLog($"拍照后的处理操作失败：{exception.Message}");
            MessageBox.Show($@"拍照后的处理操作失败：{exception.Message}");
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


    // 开启监听
    private void listenPlc_Click(object sender, EventArgs e)
    {
        try
        {
            PlcControl.Instance.StartListener(1000, OnPlcListening);
            CameraCtrl.Instance.CapturedCompleted += OnCaptured;
            Logger.Instance.AddLog("=========监听开始，1000毫秒读取一次=========");
        }
        catch (Exception exception)
        {
            Logger.Instance.AddLog($"监听失败：{exception.Message}");
            MessageBox.Show($@"监听失败：{exception.Message}");
        }
    }

    // 停止监听
    private void stopListen_Click(object sender, EventArgs e)
    {
        PlcControl.Instance.StopListener();
        CameraCtrl.Instance.CapturedCompleted -= OnCaptured;
        Logger.Instance.AddLog("监听停止");
    }

    private async Task OnPlcListening()
    {
        try
        {
            var measureNum = await PlcControl.Instance.Read<int>(PlcDataAddress.MeasureNum.GetAddress());
            var x = await PlcControl.Instance.Read<uint>(PlcDataAddress.X.GetAddress());
            var y = await PlcControl.Instance.Read<uint>(PlcDataAddress.Y.GetAddress());
            PlcControl.Instance.MeasureNum = measureNum;
            PlcControl.Instance.RealX = x.ConvertToFloat();
            PlcControl.Instance.RealY = y.ConvertToFloat();

            var nineCaliNum = await PlcControl.Instance.Read<uint>(PlcDataAddress.NineCaliNum.GetAddress());
            Console.WriteLine(nineCaliNum);
            // 限制
            if (PlcControl.Instance.NineCaliNum != nineCaliNum && nineCaliNum != 0)
            {
                RunOnUIThread(() => Logger.Instance.AddLog($"第{nineCaliNum}次执行开始"));

                PlcControl.Instance.NineCaliNum = nineCaliNum.ConvertToInt();
                // 读取到数据后执行拍照
                CameraCtrl.Instance.Capture();

                // 保存物理坐标
                _realRow.Append(x);
                _realColumn.Append(y);
            }
        }
        catch (Exception exception)
        {
            RunOnUIThread(() => Logger.Instance.AddLog($"PLC监听失败：{exception.Message}"));

            MessageBox.Show($@"PLC监听失败：{exception.Message}");
        }
    }
}