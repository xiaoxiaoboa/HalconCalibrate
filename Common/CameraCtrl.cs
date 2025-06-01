using HalconDotNet;

namespace HalconCalibration.Common;

public class CameraCtrl {
    private static readonly Lazy<CameraCtrl> _instance = new(() => new CameraCtrl());

    public static CameraCtrl Instance => _instance.Value;

    private HFramegrabber? HFrameGrabber{ get; set; }

    public HImage? Image{ get; set; }

    // 相机标定仿射关系
    public readonly HHomMat2D HomMat2D = new();

    public string Name{ get; set; } = "GigEVision2";
    public int HorizontalResolution{ get; set; }
    public int VerticalResolution{ get; set; }
    public int ImageWidth{ get; set; }
    public int ImageHeight{ get; set; }
    public int StartRow{ get; set; }
    public int StartColumn{ get; set; }
    public string Field{ get; set; } = "progressive";
    public int BitsPerChannel{ get; set; } = -1;
    public string ColorSpace{ get; set; } = "default";
    public double Generic{ get; set; } = -1;
    public string ExternalTrigger{ get; set; } = "false";

    public string CameraType{ get; set; } = "default";

    // public string Device { get; set; } = "34bd2022f532_Hikrobot_MVCS06010GC";
    public string Device{ get; set; } = "34bd202ffa29_Hikrobot_MVCS06010GC";
    public int Port{ get; set; }
    public int LineIn{ get; set; } = -1;

    public event EventHandler? CapturedCompleted;

    private CameraCtrl() {
        LoadCameraParam();
    }

    public bool Connect(out string? errorMessage) {
        errorMessage = null;
        try {
            if (HFrameGrabber != null && HFrameGrabber.IsInitialized()) throw new Exception("相机已初始化");

            HFrameGrabber = new HFramegrabber(Name, HorizontalResolution, VerticalResolution, ImageWidth,
                ImageHeight,
                StartRow, StartColumn, Field, BitsPerChannel, ColorSpace, Generic, ExternalTrigger, CameraType,
                Device,
                Port, LineIn);

            return true;
        }
        catch (Exception exception) {
            errorMessage = exception.Message;
            return false;
        }
    }

    public string? DisConnect() {
        try {
            HFrameGrabber?.CloseFramegrabber();
            return null;
        }
        catch (Exception exception) {
            return exception.Message;
        }
    }

    // 拍照
    public void Capture() {
        try {
            if (HFrameGrabber == null) throw new Exception("相机未初始化");

            HFrameGrabber.GrabImageStart(-1.0);
            Image = HFrameGrabber.GrabImageAsync(-1.0);

            CapturedCompleted?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception exception) {
            throw new Exception(exception.Message, exception);
        }
    }

    // 从ini文件中加载相机参数
    private void LoadCameraParam() {
        try {
            Name = IniControl.Instance.Read("Camera", "Name");

            int.TryParse(IniControl.Instance.Read("Camera", "HorizontalResolution"), out int h);
            HorizontalResolution = h;
            int.TryParse(IniControl.Instance.Read("Camera", "VerticalResolution"), out int v);
            VerticalResolution = v;

            int.TryParse(IniControl.Instance.Read("Camera", "ImageWidth"), out int iw);
            ImageWidth = iw;

            int.TryParse(IniControl.Instance.Read("Camera", "ImageHeight"), out int ih);
            ImageHeight = ih;
            int.TryParse(IniControl.Instance.Read("Camera", "StartRow"), out int sr);
            StartRow = sr;

            int.TryParse(IniControl.Instance.Read("Camera", "StartColumn"), out int sc);
            StartColumn = sc;

            Field = IniControl.Instance.Read("Camera", "Field");

            int.TryParse(IniControl.Instance.Read("Camera", "BitsPerChannel"), out int bpc);
            BitsPerChannel = bpc;

            ColorSpace = IniControl.Instance.Read("Camera", "ColorSpace");

            int.TryParse(IniControl.Instance.Read("Camera", "Generic"), out int g);
            Generic = g;

            ExternalTrigger = IniControl.Instance.Read("Camera", "ExternalTrigger");

            CameraType = IniControl.Instance.Read("Camera", "CameraType");

            Device = IniControl.Instance.Read("Camera", "Device");

            int.TryParse(IniControl.Instance.Read("Camera", "Port"), out int p);
            Port = p;

            int.TryParse(IniControl.Instance.Read("Camera", "LineIn"), out int l);
            LineIn = l;
        }
        catch (Exception exception) {
            Logger.Instance.AddLog($"加载相机参数失败：{exception.Message}");
        }
    }
}