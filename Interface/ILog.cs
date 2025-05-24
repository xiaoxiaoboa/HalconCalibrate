using HalconCalibration.Enum;

namespace HalconCalibration.Interface;

public interface ILog
{
    string TimeStamp { get; }
    LogLevel Level { get; }
    string Message { get; }
}