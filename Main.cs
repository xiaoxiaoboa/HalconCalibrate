using HalconCalibration.Common;
using HalconCalibration.Views;
using HalconDotNet;

namespace HalconCalibration;

public partial class Main : Form
{
    private HWindow _window;

    HImage image = new();

    private double _scale = 1.0;
    private double _zoomFactor = 1.1;

    public Main()
    {
        InitializeComponent();
        _window = hSmartWindowControl1.HalconWindow;
    }

    private void Main_Load(object sender, EventArgs e)
    {
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
        var msg = CameraCtrl.Instance.Connect();
        if (msg == null)
        {
            connectCamera.BackColor = Color.LimeGreen;
            Logger.Instance.AddLog("相机连接成功");
        }
        else
        {
            Logger.Instance.AddLog(msg);
        }
    }


    // 拍照
    private void takeGraphic_Click(object sender, EventArgs e)
    {
        try
        {
            image = CameraCtrl.Instance.TakeGraphic();
            image.DispObj(_window);
        }
        catch (Exception exception)
        {
            Logger.Instance.AddLog(exception.Message);
        }
    }

    private void displayLogs_Click(object sender, EventArgs e)
    {
        var logs = new Logs();
        logs.Show();
    }

    private void connectPlc_Click(object sender, EventArgs e)
    {
        Logger.Instance.AddLog("log");
    }
}