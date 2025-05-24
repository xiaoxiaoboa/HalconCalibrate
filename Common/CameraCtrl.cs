using HalconDotNet;

namespace HalconCalibration.Common;

public class CameraCtrl
{
    private static readonly Lazy<CameraCtrl> _instance = new(() => new CameraCtrl());

    public static CameraCtrl Instance => _instance.Value;

    private HFramegrabber? HFrameGrabber { get; set; }

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


    public string? Connect()
    {
        try
        {
            HFrameGrabber = new HFramegrabber(Name, HorizontalResolution, VerticalResolution, ImageWidth,
                ImageHeight,
                StartRow, StartColumn, Field, BitsPerChannel, ColorSpace, Generic, ExternalTrigger, CameraType, Device,
                Port, LineIn);
            return null;
        }
        catch (Exception exception)
        {
            return exception.Message;
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

    public HImage TakeGraphic()
    {
        try
        {
            HFrameGrabber?.GrabImageStart(-1.0);
            return HFrameGrabber?.GrabImageAsync(-1.0);
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