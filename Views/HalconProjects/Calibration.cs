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
    private HWindow? _window;

    private Threshold? _threshold;

    // 像素坐标的元组。 
    private readonly HTuple _pixelRow = new();
    private readonly HTuple _pixelColumn = new();

    // 机械坐标数组；按照九点标定顺序一次添加
    private readonly HTuple _realRow = new();
    private readonly HTuple _realColumn = new();


    public Calibration(HWindow hWindow)
    {
        InitializeComponent();

        _window = hWindow;
        Disposed += FormClosing;
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
    private async void OnCaptured(object? sender, EventArgs e)
    {
        try
        {
            if (CameraCtrl.Instance.Image == null) throw new Exception("图像未加载");

            if (_threshold == null) return;
            // 执行halcon,获取 像素坐标
            var (row, column) = _threshold.HandleThreshold();

            // 保存像素坐标
            _pixelRow.Append(row);
            _pixelColumn.Append(column);
            // 保存物理坐标
            _realRow.Append(PlcControl.Instance.RealX);
            _realColumn.Append(PlcControl.Instance.RealY);

            RunOnUIThread(() => Logger.Instance.AddLog($"像素坐标，x：{row}，y：{column}"));
            RunOnUIThread(() =>
                Logger.Instance.AddLog($"机械坐标，x：{PlcControl.Instance.RealX}，y：{PlcControl.Instance.RealY}"));

            try
            {
                if (PlcControl.Instance.IsConnected)
                    // 写入九点矫正编号给plc,表示本次点对添加完成
                    await PlcControl.Instance.Write(PlcDataAddress.NineCaliNumCheck.GetAddress(),
                        PlcControl.Instance.NineCaliNum);
            }
            catch (Exception exception)
            {
                RunOnUIThread(() => Logger.Instance.AddLog($"写入PLC失败：{exception.Message}", LogLevel.Error));
            }


            if (PlcControl.Instance.NineCaliNum == 9)
            {
                // 点对仿射
                CameraCtrl.Instance.HomMat2D.VectorToHomMat2d(_pixelRow, _pixelColumn, _realRow, _realColumn);

                // 停止监听
                RunOnUIThread(() =>
                {
                    stopListen_Click(sender, e);
                    Logger.Instance.AddLog("九点标定完成");
                });

                // 恢复默认
                PlcControl.Instance.NineCaliNum = 0;
            }
        }
        catch (Exception exception)
        {
            RunOnUIThread(() => Logger.Instance.AddLog($"九点标定操作失败：{exception.Message}", LogLevel.Error));
            MessageBox.Show($@"九点标定操作失败：{exception.Message}");
        }
    }


    /// 开始九点标定
    /// 1：监听：是否开启九点标定
    /// 2；两个集合：一个像素集合，一个机械集合
    /// 3：监听 进行到第几次标定
    /// 4：每次标定时，分别获取像素坐标和机械坐标，分别添加到 集合中
    /// 5：最后：建立 仿射关系：像素集合与机械集合的仿射关系。
    /// 6：测试：输入像素坐标，使用仿射矩阵 求对应的机械坐标
    private void listenPlc_Click(object sender, EventArgs e)
    {
        try
        {
            // 监听进行第几次九点标定，触发拍照，记录机械坐标位置
            PlcControl.Instance.StartListener(1000, OnPlcListening);
            // 监听拍照事件，事件中：halcon算法，为了获取像素坐标
            CameraCtrl.Instance.CapturedCompleted += OnCaptured;
            Logger.Instance.AddLog("=========监听开始，1000毫秒读取一次=========");
        }
        catch (Exception exception)
        {
            Logger.Instance.AddLog($"监听失败：{exception.Message}", LogLevel.Error);
            MessageBox.Show($@"监听失败：{exception.Message}");
        }
    }

    // 停止监听
    private void stopListen_Click(object? sender, EventArgs e)
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
            // 限制
            if (PlcControl.Instance.NineCaliNum != nineCaliNum && nineCaliNum != 0)
            {
                RunOnUIThread(() => Logger.Instance.AddLog($"第{nineCaliNum}次执行开始"));

                PlcControl.Instance.NineCaliNum = nineCaliNum.ConvertToInt();
                // 读取到数据后执行拍照
                CameraCtrl.Instance.Capture();
            }
        }
        catch (Exception exception)
        {
            RunOnUIThread(() => Logger.Instance.AddLog($"PLC监听失败：{exception.Message}", LogLevel.Error));

            MessageBox.Show($@"PLC监听失败：{exception.Message}");
        }
    }

    private void thresholdBtn_Click(object sender, EventArgs e)
    {
        if (_threshold == null || _threshold.IsDisposed)
        {
            if (_window == null) return;
            _threshold = new Threshold(_window);
            _threshold.Show();
        }
        else
        {
            _threshold.Close();
        }
    }

    private void FormClosing(object? sender, EventArgs e)
    {
        _threshold?.Dispose();
    }
}