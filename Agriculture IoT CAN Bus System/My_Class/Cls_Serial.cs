using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Class
{
    public class Cls_Serial
    {
        /// <summary>
        /// 获取串口号   显示系统可用串口
        /// </summary>
        /// <returns>串口类型组</returns>
        public static List<Serial_Info> GetPorts()
        {
            List<Serial_Info> back = new List<Serial_Info>();
            foreach (string _s in SerialPort.GetPortNames())
            {
                Serial_Info _si = new Serial_Info();
                _si.Name = _s;
                _si.Des = "USB-SERIAL";
                back.Add(_si);
            }
            return back;
        }
    }

    /// <summary>
    /// 串口信息实体
    /// </summary>
    public class Serial_Info
    {

        /// <summary>
        /// 串口号
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Des { get; set; }

        /// <summary>
        /// 获取所有串口号
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + ":" + Des;
        }
    }

}
