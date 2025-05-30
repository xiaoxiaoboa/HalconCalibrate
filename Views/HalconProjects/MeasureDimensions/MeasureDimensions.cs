using System.ComponentModel;
using HalconDotNet;

namespace HalconCalibration.Views.HalconProjects.MeasureDimensions;

[ToolboxItem(false)]
public partial class MeasureDimensions : UserControl
{
    private HWindow? _window;

    // 窗口
    private Threshold? _threshold;
    private Config? _config;


    public MeasureDimensions(HWindow hWindow)
    {
        _window = hWindow;
        InitializeComponent();
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

    // 打开阈值分割窗口
    private void threshold_Click(object sender, EventArgs e)
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

    // 打开项目配置窗口
    private void config_Click(object sender, EventArgs e)
    {
        if (_config == null || _config.IsDisposed)
        {
            if (_window == null || _threshold?.SelectRegion == null)
            {
                MessageBox.Show(@"先阈值分割");
            }
            else
            {
                _config = new Config(_window, _threshold.SelectRegion);
                _config.Show();
            }
        }
        else
        {
            _config.Close();
        }
    }
}