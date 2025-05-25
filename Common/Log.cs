using HalconCalibration.Enums;
using HalconCalibration.Interface;

namespace HalconCalibration.Common
{
    public class Log : ILog
    {
        public string TimeStamp { get; }
        public LogLevel Level { get; }
        public string Message { get; }

        public Log(string timeStamp, LogLevel level, string message)
        {
            TimeStamp = timeStamp;
            Level = level;
            Message = message;
        }
    }
}