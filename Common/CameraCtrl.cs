using HalconDotNet;

namespace HalconCalibration.Common;

public class CameraCtrl
{
    private static readonly Lazy<CameraCtrl> _instance = new(() => new CameraCtrl());

    public static CameraCtrl Instance => _instance.Value;

    private HFramegrabber? HFrameGrabber { get; set; }

    public HImage? Image { get; set; }

    // 相机标定仿射关系
    public HHomMat2D HomMat2D = new();

    public string Name { get; set; } = "GigEVision2";
    public int HorizontalResolution { get; set; }
    public int VerticalResolution { get; set; }
    public int ImageWidth { get; set; }
    public int ImageHeight { get; set; }
    public int StartRow { get; set; }
    public int StartColumn { get; set; }
    public string Field { get; set; } = "progressive";
    public int BitsPerChannel { get; set; } = -1;
    public string ColorSpace { get; set; } = "default";
    public double Generic { get; set; } = -1;
    public string ExternalTrigger { get; set; } = "false";
    public string CameraType { get; set; } = "default";
    public string Device { get; set; } = "34bd2022f532_Hikrobot_MVCS06010GC";
    public int Port { get; set; }
    public int LineIn { get; set; } = -1;

    public event EventHandler? CapturedCompleted;

    public bool Connect(out string? errorMessage)
    {
        errorMessage = null;
        try
        {
            if (HFrameGrabber != null && HFrameGrabber.IsInitialized()) throw new Exception("相机已初始化");

            HFrameGrabber = new HFramegrabber(Name, HorizontalResolution, VerticalResolution, ImageWidth,
                ImageHeight,
                StartRow, StartColumn, Field, BitsPerChannel, ColorSpace, Generic, ExternalTrigger, CameraType,
                Device,
                Port, LineIn);

            return true;
        }
        catch (Exception exception)
        {
            errorMessage = exception.Message;
            return false;
        }
    }

    public string? DisConnect()
    {
        try
        {
            HFrameGrabber?.CloseFramegrabber();
            return null;
        }
        catch (Exception exception)
        {
            return exception.Message;
        }
    }

    public void Capture()
    {
        try
        {
            HFrameGrabber?.GrabImageStart(-1.0);
            if (HFrameGrabber == null) throw new Exception("相机未初始化");

            Image = HFrameGrabber.GrabImageAsync(-1.0);

            CapturedCompleted?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

    public void SetGraphicSize(int w, int h)
    {
        ImageWidth = w;
        ImageHeight = h;
    }
}