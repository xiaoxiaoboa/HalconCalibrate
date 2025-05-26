using HalconCalibration.Common;
using HalconCalibration.Enums;
using HalconCalibration.Views;
using HalconCalibration.Views.HalconProjects;
using HalconDotNet;

namespace HalconCalibration;

public partial class Main : Form
{
    private HWindow? _window;

    private double _scale = 1.0;
    private double _zoomFactor = 1.1;

    private (HalconPorjects?, UserControl) _currentPorject;

    public Main()
    {
        InitializeComponent();
        _window = hSmartWindowControl1.HalconWindow;
    }

    private void Main_Load(object sender, EventArgs e)
    {
        _window?.SetColor("red");

        ninePointCalib_Click(sender, e);
    }

    // 需要手动绑定事件，使用【设计器】绑定不生效
    private void hSmartWindowControl1_Load(object sender, EventArgs e)
    {
        hSmartWindowControl1.MouseWheel += hSmartWindowControl1_HMouseWheel;
    }

    // hwindow鼠标滚动事件
    private void hSmartWindowControl1_HMouseWheel(object? sender, MouseEventArgs e)
    {
        Point pt = hSmartWindowControl1.Location;

        MouseEventArgs newe = new MouseEventArgs(e.Button, e.Clicks, (int)e.X - pt.X, (int)e.Y - pt.Y, e.Delta);
        hSmartWindowControl1.HSmartWindowControl_MouseWheel(sender, newe);
    }

    // 相机连接
    private void connectCamera_Click(object sender, EventArgs e)
    {
        if (CameraCtrl.Instance.Connect(out var msg))
        {
            Logger.Instance.AddLog("相机连接成功");

            connectCamera.Enabled = false;
            indicatorLight1.IsOn = !indicatorLight1.IsOn;
        }
        else
        {
            Logger.Instance.AddLog($"相机连接失败：{msg}");
        }
    }


    // 拍照
    private void takeGraphic_Click(object sender, EventArgs e)
    {
        try
        {
            CameraCtrl.Instance.Capture();
        }
        catch (Exception exception)
        {
            Logger.Instance.AddLog($"拍照失败：{exception.Message}");
        }
    }

    private void displayLogs_Click(object sender, EventArgs e)
    {
        var logs = new Logs();
        logs.Show();
    }

    private void connectPlc_Click(object sender, EventArgs e)
    {
        
    }

    // 切换到标定项目
    private void ninePointCalib_Click(object sender, EventArgs e)
    {
        if (_window == null) return;
        var cali = new Calibration(_window);
        SwitchProject(cali, HalconPorjects.NinePointCalibration);
    }

    // 切换项目通用函数
    private void SwitchProject(UserControl control, HalconPorjects type)
    {
        if (_currentPorject.Item1 != type)
        {
            _currentPorject.Item2?.Dispose();
            control.Parent = panel2;
            control.Dock = DockStyle.Fill;

            // 更新状态
            _currentPorject.Item1 = HalconPorjects.NinePointCalibration;
            _currentPorject.Item2 = control;
        }
    }

    // 断开相机
    private void disconnectCamera_Click(object sender, EventArgs e)
    {
        CameraCtrl.Instance.DisConnect();
        
        connectCamera.Enabled = true;
        indicatorLight1.IsOn = !indicatorLight1.IsOn;
        
        Logger.Instance.AddLog("相机断开");
    }
}