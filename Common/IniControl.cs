using System.Globalization;
using IniParser;
using IniParser.Model;

namespace HalconCalibration.Common {
    public class IniControl {
        private static readonly IniControl _instance = new IniControl();

        public static IniControl Instance => _instance;

        private readonly FileIniDataParser _parser = new FileIniDataParser();
        private IniData? _data;

        private readonly string _filePath = Path.Combine(Application.StartupPath + "\\config.ini");

        private IniControl() { }


        // 基准点属性
        public float BaseX{ get; set; }
        public float BaseY{ get; set; }
        public float BaseAngle{ get; set; }
        public float RotateCenterX{ get; set; }
        public float RotateCenterY{ get; set; }

        /// <summary>
        /// 初始化配置文件控制器。
        /// 该方法检查配置文件是否存在，如果存在则加载配置文件的内容到内存中。
        /// 如果配置文件不存在，则通过日志记录工具记录错误信息。
        /// </summary>
        public void Initialize() {
            if (File.Exists(_filePath)) {
                _data = _parser.ReadFile(_filePath);
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
        public string Read(string field, string key) {
            try {
                if (_data == null) throw new FileNotFoundException("ini文件未加载", _filePath);
                return _data[field][key]!;
            }
            catch (Exception exception) {
                throw new Exception(exception.Message, exception);
            }
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
        public void Write(string field, string key, string value) {
            try {
                if (_data == null) throw new FileNotFoundException("ini文件未加载");
                if (File.Exists(_filePath)) {
                    _data[field][key] = value;
                    _parser.WriteFile(_filePath, _data);
                }
                else {
                    throw new FileNotFoundException("无法写入，ini文件不存在", _filePath);
                }
            }
            catch (Exception exception) {
                throw new Exception(exception.Message, exception);
            }
        }
    }
}