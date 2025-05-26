using HalconCalibration.Enums;
using S7.Net;
using Timer = System.Timers.Timer;

namespace HalconCalibration.Common
{
    public class PlcControl
    {
        private static readonly Lazy<PlcControl> _instance = new(() => new PlcControl());
        private Plc? _plc;

        private Timer? _timer;

        public bool IsConnected => _plc is { IsConnected: true };

        public static PlcControl Instance => _instance.Value;

        // DB50
        public int FaultCode { get; set; }
        public int MeasureNum { get; set; }


        public int NineCaliNum { get; set; }

        public int CenterCaliNum { get; set; }
        public int CurrentControlMode { get; set; }
        public float RealX { get; set; }
        public float RealY { get; set; }
        public float RealZ { get; set; }

        public float RealR { get; set; }

        // DB51
        public float OffsetR { get; set; }
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
        public int MeasureNumCheck { get; set; }
        public int CenterCaliNumCheck { get; set; }
        public int FeedPosition { get; set; }
        public int NineCaliNumCheck { get; set; }
        public int ControlMode { get; set; }


        private PlcControl()
        {
        }

        // 启动监听
        /// <summary>
        /// 启动监听器以定期执行指定的回调函数。
        /// 如果 PLC 未连接，则抛出异常。如果监听器已启动，则不会重复启动。
        /// </summary>
        /// <param name="interval">监听器触发的时间间隔，以毫秒为单位。</param>
        /// <param name="callback">每次监听器触发时执行的异步回调函数。</param>
        public void StartListener(int interval, Func<Task> callback)
        {
            if (_timer == null) return;
            if (!IsConnected) throw new Exception("PLC 未连接");

            _timer = new Timer();
            _timer.Interval = interval; // 每 1000ms 读取一次
            _timer.AutoReset = true;
            _timer.Elapsed += async (s, e) => await callback();
            _timer.Start();
        }

        /// <summary>
        /// 停止当前正在运行的监听器。
        /// 如果监听器未启动，则此方法不执行任何操作。
        /// 调用此方法后，监听器将停止触发回调函数，并释放相关资源。
        /// </summary>
        public void StopListener()
        {
            _timer?.Stop();
            _timer = null;
        }


        // 连接
        /// <summary>
        /// 连接到指定的 PLC 设备。
        /// 该方法从配置文件中读取 PLC 的 IP 地址和端口号，初始化并打开与 PLC 的连接。
        /// 如果已经存在活动的连接，则不会重复连接。
        /// </summary>
        public void Connect()
        {
            // var ip = IniControl.Instance.Read("PlcConfig", "IP");
            // var port = IniControl.Instance.Read("PlcConfig", "Port");
            // if (_plc != null && _plc.IsConnected)
            //     return;
            // _plc = new Plc(CpuType.S71500, ip, Convert.ToInt32(port), 0, 1);
            //
            // _plc.Open();
        }

        // 断开
        /// <summary>
        /// 断开与PLC的连接，并执行相关资源的清理操作。
        /// 如果当前未连接到PLC，则不会执行任何操作。
        /// 调用此方法后，PLC连接状态将被关闭，定时器停止运行，相关实例置为空。
        /// </summary>
        public void Disconnect()
        {
            if (_plc != null && _plc.IsConnected)
            {
                _plc.Close();
                _plc = null;
            }

            _timer?.Stop();
        }

        // 读plc
        /// <summary>
        /// 异步读取指定地址的PLC数据，并将其转换为目标类型。
        /// 如果PLC未连接，则抛出异常。如果读取失败，则抛出包含错误信息的异常。
        /// </summary>
        /// <param name="address">要读取的PLC数据地址，通常通过<see cref="PlcDataAddress"/>枚举的扩展方法获取。</param>
        /// <typeparam name="T">目标数据类型，读取的数据将尝试转换为此类型。</typeparam>
        /// <returns>返回从PLC读取并转换为目标类型的数据。</returns>
        public async Task<T> Read<T>(string address)
        {
            try
            {
                if (_plc == null || !IsConnected) throw new Exception("PLC未连接");
                var result = await _plc.ReadAsync(address);
                if (result is null) throw new Exception();
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch (Exception exception)
            {
                throw new Exception($"读取数据失败：{exception.Message}");
            }
        }

        // 写plc
        /// <summary>
        /// 将指定的值写入到PLC的指定地址。
        /// 如果PLC未连接，则抛出异常。如果写入失败，将捕获异常并抛出新的异常信息。
        /// </summary>
        /// <param name="address">要写入的PLC地址，该地址需符合PLC地址格式规范。</param>
        /// <param name="value">要写入的数据值，可以是任意支持的对象类型。</param>
        /// <return>无返回值。</return>
        public async Task Write(string address, object value)
        {
            try
            {
                if (_plc == null || !IsConnected) throw new InvalidOperationException("PLC 未连接");
                await _plc.WriteAsync(address, value);
            }
            catch (Exception exception)
            {
                throw new Exception("PLC读取数据失败", exception);
            }
        }

        // 处理偏移
        /// <summary>
        /// 处理偏移计算并将结果写入PLC。
        /// 该方法根据当前的测量编号（MeasureNum）和识别工具块的运行状态，计算角度、X轴和Y轴的偏移量。
        /// 如果识别工具块运行失败或结果不符合预期，则抛出异常。
        /// 计算完成后，将偏移值写入PLC，并更新确认编号。
        /// </summary>
        /// <returns>无返回值。</returns>
        /// <exception cref="Exception">当识别工具块运行失败或偏移计算过程中发生错误时抛出。</exception>
        public async Task HandleOffset()
        {
        }
    }
}