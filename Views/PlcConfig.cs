using HalconCalibration.Common;

namespace HalconCalibration.Views;

public partial class PlcConfig : Form {
    public PlcConfig() {
        InitializeComponent();
    }

    private void PlcConfig_Load(object sender, EventArgs e) {
        try {
            textBox1.Text = IniControl.Instance.Read("PlcConfig", "IP");
            textBox2.Text = IniControl.Instance.Read("PlcConfig", "Port");
        }
        catch (Exception exception) {
            Logger.Instance.AddLog($"加载Plc参数失败：{exception.Message}");
            MessageBox.Show(@$"加载Plc参数失败：{exception.Message}");
        }
    }

    // 关闭窗口并保存
    private void PlcConfig_FormClosing(object sender, FormClosingEventArgs e) {
        var ip = textBox1.Text;
        var port = textBox2.Text;


        try {
            if (int.TryParse(port, out int p)) {
                PlcControl.Instance.Ip = ip;
                PlcControl.Instance.Port = p;
            }

            IniControl.Instance.Write("PlcConfig", "IP", ip);
            IniControl.Instance.Write("PlcConfig", "Port", port);
        }
        catch (Exception exception) {
            Logger.Instance.AddLog($"保存相机参数失败：{exception.Message}");
            MessageBox.Show(@$"保存相机参数失败：{exception.Message}");
        }
    }
}