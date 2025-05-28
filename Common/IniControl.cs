using System.Globalization;
using IniParser;
using IniParser.Model;

namespace HalconCalibration.Common
{
    public class IniControl
    {
        private static readonly IniControl _instance = new IniControl();

        public static IniControl Instance => _instance;

        private readonly FileIniDataParser _parser = new FileIniDataParser();
        private IniData _data;

        private readonly string _filePath = Path.Combine(Application.StartupPath + "\\config.ini");

        private IniControl()
        {
        }

        public string Ip { get; set; }
        public int Port { get; set; }

        // 基准点属性
        public float BaseX { get; set; }
        public float BaseY { get; set; }
        public float BaseAngle { get; set; }
        public float RotateCenterX { get; set; }
        public float RotateCenterY { get; set; }

        // 加载文件
        /// <summary>
        /// 加载配置文件并解析其中的内容以初始化相关属性。
        /// 如果配置文件存在，则读取文件中的各项配置值并将其赋值给对应的属性；
        /// 如果配置文件不存在，则通过日志记录工具记录错误信息。
        /// 配置文件路径为应用程序启动路径下的 "config.ini" 文件。
        /// 该方法主要用于加载与 PLC 配置和基准点相关的参数，包括 IP 地址、端口、基准点坐标及旋转中心等。
        /// </summary>
        public void Initialize()
        {
            if (File.Exists(_filePath))
            {
                _data = _parser.ReadFile(_filePath);

                Ip = _data["PlcConfig"]["IP"];
                Port = Convert.ToInt32(_data["PlcConfig"]["Port"]);
                BaseX = Convert.ToSingle(_data["PointConfig"]["BaseX"], CultureInfo.InvariantCulture);
                BaseY = Convert.ToSingle(_data["PointConfig"]["BaseY"], CultureInfo.InvariantCulture);
                BaseAngle = Convert.ToSingle(_data["PointConfig"]["BaseAngle"], CultureInfo.InvariantCulture);
                RotateCenterX = Convert.ToSingle(_data["PointConfig"]["RotateCenterX"], CultureInfo.InvariantCulture);
                RotateCenterY = Convert.ToSingle(_data["PointConfig"]["RotateCenterY"], CultureInfo.InvariantCulture);
            }
            else
                Logger.Instance.AddLog("ini文件不存在");
        }

        // 读取ini值
        /// <summary>
        /// 从指定的字段和键中读取配置文件中的值。
        /// 该方法通过访问内部存储的配置数据结构，获取与字段和键对应的值。
        /// 如果字段或键不存在，则返回 null。
        /// </summary>
        /// <param name="field">配置文件中的字段名称，表示配置的分组。</param>
        /// <param name="key">字段下的键名称，用于定位具体的配置项。</param>
        /// <returns>返回与指定字段和键对应的配置值。如果未找到，则返回 null。</returns>
        public string Read(string field, string key)
        {
            return _data?[field][key]!;
        }

        // 写入ini值
        /// <summary>
        /// 将指定的值写入配置文件中对应的字段和键位置。
        /// 该方法首先更新内部存储的配置数据结构中的值，然后检查配置文件是否存在。
        /// 如果配置文件存在，则将更新后的数据写入文件；如果配置文件不存在，则通过日志记录工具记录错误信息。
        /// </summary>
        /// <param name="field">配置文件中的字段名称，表示配置的分组。</param>
        /// <param name="key">字段下的键名称，用于定位具体的配置项。</param>
        /// <param name="value">需要写入的配置值。</param>
        public void Write(string field, string key, string value)
        {
            _data[field][key] = value;
            if (File.Exists(_filePath))
            {
                _parser.WriteFile(_filePath, _data);
            }
            else
            {
                Logger.Instance.AddLog("无法写入，ini文件不存在");
            }
        }

        /// <summary>
        /// 将当前配置参数保存到配置文件中。
        /// 该方法将类实例中的各项属性值写入配置文件，包括 PLC 的 IP 地址、端口号，
        /// 以及基准点的 X 坐标、Y 坐标、旋转角度和旋转中心坐标。
        /// 配置文件通过键值对的形式存储，其中 "PlcConfig" 字段保存 PLC 相关配置，
        /// "PointConfig" 字段保存基准点相关配置。
        /// 如果在保存过程中发生异常，将抛出异常并中断保存操作。
        /// 该方法通常在应用程序关闭或用户手动保存配置时调用，
        /// 确保当前设置能够持久化到配置文件中以便后续使用。
        /// </summary>
        public void SaveFile()
        {
            try
            {
                Instance.Write("PlcConfig", "IP", Ip);
                Instance.Write("PlcConfig", "Port", Port.ToString());
                Instance.Write("PointConfig", "BaseX", BaseX.ToString(CultureInfo.CurrentCulture));
                Instance.Write("PointConfig", "BaseY", BaseY.ToString(CultureInfo.CurrentCulture));
                Instance.Write("PointConfig", "RotateCenterX", RotateCenterX.ToString(CultureInfo.CurrentCulture));
                Instance.Write("PointConfig", "BaseAngle", BaseAngle.ToString(CultureInfo.CurrentCulture));
                Instance.Write("PointConfig", "RotateCenterY", RotateCenterY.ToString(CultureInfo.CurrentCulture));
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}