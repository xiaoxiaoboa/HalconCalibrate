using HalconCalibration.Common;

namespace HalconCalibration.Views;

public partial class CameraConfig : Form {
    public CameraConfig() {
        InitializeComponent();
    }

    private void CameraConfig_Load(object sender, EventArgs e) {
        LoadCameraParam();
    }

    // 关闭窗口并保存
    private void CameraConfig_FormClosing(object sender, FormClosingEventArgs e) {
        var name = textBox1.Text;
        var horizontalResolution = textBox2.Text;
        var verticalResolution = textBox3.Text;
        var imageWidth = textBox4.Text;
        var imageHeight = textBox5.Text;
        var startRow = textBox6.Text;
        var startColumn = textBox7.Text;
        var field = textBox8.Text;
        var bitsPerChannel = textBox9.Text;
        var colorSpace = textBox10.Text;
        var generic = textBox11.Text;
        var externalTrigger = textBox12.Text;
        var cameraType = textBox13.Text;
        var device = textBox14.Text;
        var port = textBox15.Text;
        var lineIn = textBox16.Text;

        CameraCtrl.Instance.Name = name;
        CameraCtrl.Instance.ExternalTrigger = externalTrigger;
        CameraCtrl.Instance.Field = field;
        CameraCtrl.Instance.ColorSpace = colorSpace;
        CameraCtrl.Instance.CameraType = cameraType;
        CameraCtrl.Instance.Device = device;

        CameraCtrl.Instance.HorizontalResolution = Convert.ToInt32(horizontalResolution);
        CameraCtrl.Instance.VerticalResolution = Convert.ToInt32(verticalResolution);
        CameraCtrl.Instance.ImageWidth = Convert.ToInt32(imageWidth);
        CameraCtrl.Instance.ImageHeight = Convert.ToInt32(imageHeight);
        CameraCtrl.Instance.StartRow = Convert.ToInt32(startRow);
        CameraCtrl.Instance.StartColumn = Convert.ToInt32(startColumn);
        CameraCtrl.Instance.BitsPerChannel = Convert.ToInt32(bitsPerChannel);
        CameraCtrl.Instance.Generic = Convert.ToInt32(generic);
        CameraCtrl.Instance.Port = Convert.ToInt32(port);
        CameraCtrl.Instance.LineIn = Convert.ToInt32(lineIn);

        try {
            IniControl.Instance.Write("Camera", "Name", name);
            IniControl.Instance.Write("Camera", "Field", field);
            IniControl.Instance.Write("Camera", "ColorSpace", colorSpace);
            IniControl.Instance.Write("Camera", "ExternalTrigger", externalTrigger);
            IniControl.Instance.Write("Camera", "CameraType", cameraType);
            IniControl.Instance.Write("Camera", "Device", device);
            IniControl.Instance.Write("Camera", "HorizontalResolution", horizontalResolution);
            IniControl.Instance.Write("Camera", "VerticalResolution", verticalResolution);
            IniControl.Instance.Write("Camera", "ImageWidth", imageWidth);
            IniControl.Instance.Write("Camera", "ImageHeight", imageHeight);
            IniControl.Instance.Write("Camera", "StartRow", startRow);
            IniControl.Instance.Write("Camera", "StartColumn", startColumn);
            IniControl.Instance.Write("Camera", "BitsPerChannel", bitsPerChannel);
            IniControl.Instance.Write("Camera", "Generic", generic);
            IniControl.Instance.Write("Camera", "Port", port);
            IniControl.Instance.Write("Camera", "LineIn", lineIn);
        }
        catch (Exception exception) {
            Logger.Instance.AddLog($"保存相机参数失败：{exception.Message}");
            MessageBox.Show(@$"保存相机参数失败：{exception.Message}");
        }
    }

    // 加载相机参数
    private void LoadCameraParam() {
        try {
            textBox1.Text = IniControl.Instance.Read("Camera", "Name");

            textBox2.Text = IniControl.Instance.Read("Camera", "HorizontalResolution");

            textBox3.Text = IniControl.Instance.Read("Camera", "VerticalResolution");
            textBox4.Text = IniControl.Instance.Read("Camera", "ImageWidth");

            textBox5.Text = IniControl.Instance.Read("Camera", "ImageHeight");
            textBox6.Text = IniControl.Instance.Read("Camera", "StartRow");

            textBox7.Text = IniControl.Instance.Read("Camera", "StartColumn");

            textBox8.Text = IniControl.Instance.Read("Camera", "Field");

            textBox9.Text = IniControl.Instance.Read("Camera", "BitsPerChannel");

            textBox10.Text = IniControl.Instance.Read("Camera", "ColorSpace");

            textBox11.Text = IniControl.Instance.Read("Camera", "Generic");

            textBox12.Text = IniControl.Instance.Read("Camera", "ExternalTrigger");

            textBox13.Text = IniControl.Instance.Read("Camera", "CameraType");

            textBox14.Text = IniControl.Instance.Read("Camera", "Device");

            textBox15.Text = IniControl.Instance.Read("Camera", "Port");

            textBox16.Text = IniControl.Instance.Read("Camera", "LineIn");
        }
        catch (Exception exception) {
            Logger.Instance.AddLog($"加载相机参数失败：{exception.Message}");
            MessageBox.Show(@$"加载相机参数失败：{exception.Message}");
        }
    }
}