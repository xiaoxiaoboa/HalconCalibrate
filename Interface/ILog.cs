using HalconCalibration.Enums;

namespace HalconCalibration.Interface;

public interface ILog
{
    string TimeStamp { get; }
    LogLevel Level { get; }
    string Message { get; }
}