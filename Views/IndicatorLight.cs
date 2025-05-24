using System.ComponentModel;

namespace HalconCalibration.Views {
    public class IndicatorLight : Control {
        private bool isOn = false;
        private Color onColor = Color.LimeGreen;
        private Color offColor = Color.Gray;

        [Category("Indicator")]
        public bool IsOn{
            get => isOn;
            set {
                isOn = value;
                Invalidate();
            }
        }

        [Category("Indicator")]
        public Color OnColor{
            get => onColor;
            set {
                onColor = value;
                Invalidate();
            }
        }

        [Category("Indicator")]
        public Color OffColor{
            get => offColor;
            set {
                offColor = value;
                Invalidate();
            }
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // 重新绘制，防止尺寸变化时残影
        }
        
        public IndicatorLight() {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.Size = new Size(30, 30);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Color fillColor = isOn ? onColor : offColor;
            using (SolidBrush brush = new SolidBrush(fillColor)) {
                int diameter = Math.Min(this.Width, this.Height) - 2;
                int x = (this.Width - diameter) / 2;
                int y = (this.Height - diameter) / 2;

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillEllipse(brush, x, y, diameter, diameter);
                e.Graphics.DrawEllipse(Pens.Black, x, y, diameter, diameter);
            }
        }
    }
}