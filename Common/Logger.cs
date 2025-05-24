using System.ComponentModel;
using System.Text;
using HalconCalibration.Enum;
using HalconCalibration.Interface;
using Microsoft.VisualBasic.Logging;

namespace HalconCalibration.Common;

public class Logger
{
    private static readonly Logger _instance = new Logger();
    private readonly BindingList<ILog> _bindingLogList = new BindingList<ILog>();
    private readonly object _lock = new object();

    public static Logger Instance => _instance;

    public BindingList<ILog> Logs
    {
        get
        {
            lock (_lock)
            {
                return _bindingLogList;
            }
        }
    }

    private Logger()
    {
    }

    // 添加日志
    /// <summary>
    /// 添加日志信息到日志列表中。
    /// </summary>
    /// <param name="message">要记录的日志消息内容，如果为 null 则不进行记录。</param>
    /// <param name="level">日志级别，默认值为 LogLevel.Info，表示信息类型的日志。</param>
    public void AddLog(string message, LogLevel level = LogLevel.Info)
    {
        if (message == null) return;
        // 格式化时间字符串
        var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        lock (_lock)
        {
            _bindingLogList.Add(new Log(timestamp, level, message));
        }
    }

    // 导出
    /// <summary>
    /// 将日志数据导出为CSV文件。
    /// </summary>
    /// <param name="filename">要保存的CSV文件的完整路径和名称。如果为空或无效，可能导致导出失败。</param>
    /// <return>返回描述导出结果的字符串。如果成功，则返回“导出日志成功”；如果失败，则返回包含错误信息的字符串。</return>
    public async Task<string> ExportToCsv(string filename)
    {
        List<ILog> logsCopy;
        lock (_lock)
        {
            logsCopy = new List<ILog>(_bindingLogList);
        }

        try
        {
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                await sw.WriteLineAsync("时间,等级,信息");

                foreach (var log in logsCopy)
                {
                    var timestamp = EscapeCsvField(log.TimeStamp);
                    var level = EscapeCsvField(log.Level.ToString());
                    var message = EscapeCsvField(log.Message);
                    await sw.WriteLineAsync($"{timestamp},{level},{message}");
                }
            }

            return "导出日志成功";
        }
        catch (Exception exception)
        {
            return $"导出日志失败：{exception.Message}";
        }
    }

    /// <summary>
    /// 对字段进行CSV格式的转义处理，以确保其在CSV文件中的正确性。
    /// </summary>
    /// <param name="field">需要转义的字段内容。如果为空或null，则返回空字符串。</param>
    /// <return>返回经过转义处理的字符串。如果字段包含逗号、双引号、换行符或回车符，则会添加双引号包裹字段，并将内部双引号替换为两个双引号。</return>
    private static string EscapeCsvField(string field)
    {
        if (string.IsNullOrEmpty(field))
            return "";

        bool mustQuote = field.Contains(",") || field.Contains("\"") || field.Contains("\n") ||
                         field.Contains("\r");

        if (mustQuote)
        {
            field = field.Replace("\"", "\"\""); // 双引号替换成两个双引号
            field = $"\"{field}\""; // 外层加引号
        }

        return field;
    }
}