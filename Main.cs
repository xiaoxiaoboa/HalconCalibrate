using HalconCalibration.Common;
using HalconCalibration.Enums;
using HalconCalibration.Views;
using HalconCalibration.Views.HalconProjects;
using HalconCalibration.Views.HalconProjects.MeasureDimensions;
using HalconDotNet;

namespace HalconCalibration;

public partial class Main : Form
{
    private HWindow? _window;

    private Logs? _logs;
    private Threshold? _threshold;


    private (HalconPorjects?, UserControl) _currentProject;

    public Main()
    {
        InitializeComponent();
        _window = hSmartWindowControl1.HalconWindow;
    }

    private void Main_Load(object sender, EventArgs e)
    {
        _window?.SetColor("red");


        IniControl.Instance.Initialize();


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
        // 连接按钮关闭
        connectCamera.Enabled = false;
        if (CameraCtrl.Instance.Connect(out var msg))
        {
            Logger.Instance.AddLog("相机连接成功");

            // 断开按钮 开启
            disconnectCamera.Enabled = true;
            // 指示灯
            indicatorLight1.IsOn = !indicatorLight1.IsOn;

            CameraCtrl.Instance.CapturedCompleted += OnCaptured;
        }
        else
        {
            connectCamera.Enabled = true;
            Logger.Instance.AddLog($"相机连接失败：{msg}", LogLevel.Error);
            MessageBox.Show(@$"相机连接失败：{msg}");
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
            Logger.Instance.AddLog($"拍照失败：{exception.Message}", LogLevel.Error);
        }
    }

    // 拍照后
    private void OnCaptured(object? sender, EventArgs e)
    {
        if (CameraCtrl.Instance.Image != null)
            CameraCtrl.Instance.Image.DispObj(_window);
    }

    // 打开日志窗口
    private void displayLogs_Click(object sender, EventArgs e)
    {
        if (_logs == null || _logs.IsDisposed)
        {
            _logs = new Logs();
            _logs.Show();
        }
        else
        {
            _logs.Close();
        }
    }

    // 连接PLC
    private async void connectPlc_Click(object sender, EventArgs e)
    {
        try
        {
            // PlcControl.Instance.Connect();
            await Task.Run(() => { PlcControl.Instance.Connect(); });

            if (PlcControl.Instance.IsConnected)
            {
                indicatorLight2.IsOn = !indicatorLight2.IsOn;
                connectPlc.Enabled = false;
                disconnectPlc.Enabled = true;
                Logger.Instance.AddLog("PLC连接成功");
            }
        }
        catch (Exception exception)
        {
            Logger.Instance.AddLog(exception.Message, LogLevel.Error);
            MessageBox.Show(exception.Message);
        }
    }

    // 切换到标定项目
    private void ninePointCalib_Click(object sender, EventArgs e)
    {
        if (_window == null) return;
        var cali = new Calibration(_window);
        groupBox3.Text = @"项目-九点标定";

        
        SwitchProject(cali, HalconPorjects.NinePointCalibration);
    }

    // 切换到测量项目
    private void measure_Click(object sender, EventArgs e)
    {
        if (_window == null) return;
        var m = new MeasureDimensions(_window);
        groupBox3.Text = @"项目-尺寸测量";
        
        SwitchProject(m, HalconPorjects.MeasureDimension);
    }

    // 切换项目通用函数
    private void SwitchProject(UserControl control, HalconPorjects type)
    {
        if (_currentProject.Item1 != type)
        {
            // 切换项目时，销毁上一个
            _currentProject.Item2?.Dispose();
            
            control.Parent = panel2;
            control.Dock = DockStyle.Fill;

            // 更新状态
            _currentProject.Item1 = type;
            _currentProject.Item2 = control;
        }
    }

    // 断开相机
    private void disconnectCamera_Click(object sender, EventArgs e)
    {
        var msg = CameraCtrl.Instance.DisConnect();
        if (msg != null)
        {
            Logger.Instance.AddLog(msg);
            MessageBox.Show(msg);
            return;
        }

        connectCamera.Enabled = true;
        disconnectCamera.Enabled = false;
        indicatorLight1.IsOn = !indicatorLight1.IsOn;

        CameraCtrl.Instance.CapturedCompleted -= OnCaptured;
        Logger.Instance.AddLog("相机断开");
    }

    private void disconnectPlc_Click(object sender, EventArgs e)
    {
        PlcControl.Instance.Disconnect();

        disconnectPlc.Enabled = false;
        connectPlc.Enabled = true;
        indicatorLight2.IsOn = !indicatorLight2.IsOn;
        Logger.Instance.AddLog("PLC断开");
    }

    private void systemConfig_Click(object sender, EventArgs e)
    {
        var sysConfig = new SystemConfig();
        sysConfig.Show();
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
        CameraCtrl.Instance.DisConnect();
    }
}