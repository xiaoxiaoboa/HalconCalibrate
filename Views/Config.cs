using System.Globalization;
using HalconCalibration.Common;

namespace HalconCalibration.Views {
    public partial class Config : Form {
        public Config() {
            InitializeComponent();

            try {
                textBox1.Text = IniControl.Instance.BaseX.ToString(CultureInfo.CurrentCulture);
                textBox2.Text = IniControl.Instance.Ip;
                textBox3.Text = IniControl.Instance.Port.ToString();
                textBox4.Text = IniControl.Instance.BaseY.ToString(CultureInfo.CurrentCulture);
                textBox5.Text = IniControl.Instance.RotateCenterX.ToString(CultureInfo.CurrentCulture);
                textBox6.Text = IniControl.Instance.BaseAngle.ToString(CultureInfo.CurrentCulture);
                textBox7.Text = IniControl.Instance.RotateCenterY.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception exception) {
                Logger.Instance.AddLog(exception.Message);
            }
        }


        // 保存
        private void button1_Click(object sender, EventArgs e) {
            if (PlcControl.Instance.IsConnected) {
                Logger.Instance.AddLog("配置PLC IP前需要断开PLC连接");
                return;
            }

            var baseX = textBox1.Text;
            var ip = textBox2.Text;
            var port = textBox3.Text;
            var baseY = textBox4.Text;
            var rotateX = textBox5.Text;
            var baseAngle = textBox6.Text;
            var rotateY = textBox7.Text;

            IniControl.Instance.BaseX = Convert.ToSingle(baseX);
            IniControl.Instance.BaseY = Convert.ToSingle(baseY);
            IniControl.Instance.BaseAngle = Convert.ToSingle(baseAngle);
            IniControl.Instance.RotateCenterX = Convert.ToSingle(rotateX);
            IniControl.Instance.RotateCenterY = Convert.ToSingle(rotateY);
            IniControl.Instance.Ip = ip;
            IniControl.Instance.Port = Convert.ToInt32(port);

            try {
                IniControl.Instance.SaveFile();
                MessageBox.Show(@"保存成功");
            }
            catch (Exception exception) {
                Logger.Instance.AddLog(exception.Message);
            }
        }
    }
}