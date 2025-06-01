using System.Globalization;
using HalconCalibration.Common;

namespace HalconCalibration.Views {
    public partial class SystemConfig : Form {
        public SystemConfig() {
            InitializeComponent();

            try {
                textBox1.Text = IniControl.Instance.BaseX.ToString(CultureInfo.CurrentCulture);
                textBox4.Text = IniControl.Instance.BaseY.ToString(CultureInfo.CurrentCulture);
                textBox5.Text = IniControl.Instance.RotateCenterX.ToString(CultureInfo.CurrentCulture);
                textBox6.Text = IniControl.Instance.BaseAngle.ToString(CultureInfo.CurrentCulture);
                textBox7.Text = IniControl.Instance.RotateCenterY.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception exception) {
                Logger.Instance.AddLog(exception.Message);
            }
        }


        // 关闭窗口并保存
        private void SystemConfig_FormClosing(object sender, FormClosingEventArgs e) {
            var baseX = textBox1.Text;
            var baseY = textBox4.Text;
            var rotateX = textBox5.Text;
            var baseAngle = textBox6.Text;
            var rotateY = textBox7.Text;


            try {
                IniControl.Instance.BaseX = Convert.ToSingle(baseX);
                IniControl.Instance.BaseY = Convert.ToSingle(baseY);
                IniControl.Instance.BaseAngle = Convert.ToSingle(baseAngle);
                IniControl.Instance.RotateCenterX = Convert.ToSingle(rotateX);
                IniControl.Instance.RotateCenterY = Convert.ToSingle(rotateY);

                IniControl.Instance.Write("PointConfig", "BaseX", baseX);
                IniControl.Instance.Write("PointConfig", "BaseY", baseY);
                IniControl.Instance.Write("PointConfig", "BaseAngle", baseAngle);
                IniControl.Instance.Write("PointConfig", "RotateCenterX", rotateX);
                IniControl.Instance.Write("PointConfig", "RotateCenterY", rotateY);
            }
            catch (Exception exception) {
                Logger.Instance.AddLog($"点位写入ini文件失败：{exception.Message}");
                MessageBox.Show(@$"点位写入ini文件失败：{exception.Message}");
            }
        }
    }
}