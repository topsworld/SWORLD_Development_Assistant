using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SWorld_Downloader.Class
{
    public class Cls_Serial
    {
        /// <summary>
        /// 获取串口号
        /// </summary>
        /// <returns>串口类型组</returns>
        //public static List<Serial_Info> GetPorts()
        //{
        //    List<Serial_Info> back = new List<Serial_Info>();
        //    using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity")) //调用WMI，获取Win32_PnPEntity，即所有设备
        //    {
        //        var hardInfos = searcher.Get();
        //        foreach (var hardInfo in hardInfos)
        //        {
        //            if ((hardInfo.Properties["Name"].Value != null) &&
        //                (hardInfo.Properties["Name"].Value.ToString().Contains("COM")) &&
        //                (hardInfo.Properties["Name"].Value.ToString().ToUpper().Contains("USB"))) //筛选出名称中包含COM的
        //            {
        //                Serial_Info temp = new Serial_Info();
        //                string s = hardInfo.Properties["Name"].Value.ToString(); //获取名称
        //                int p = s.IndexOf('(');
        //                temp.Des = s.Substring(0, p); //截取描述（名称）
        //                temp.Name = s.Substring(p + 1, s.Length - p - 2); //截取串口号
        //                back.Add(temp);
        //            }
        //        }
        //        searcher.Dispose();
        //    }
        //    return back;
        //}
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

    /// <summary>
    /// 串口数据缓冲区实体
    /// </summary>
    //public class Serial_Data_Buffer
    //{
    //    /// <summary>
    //    /// 数据缓冲区
    //    /// </summary>
    //    /// <param name="_i_size">缓冲区大小</param>
    //    public Serial_Data_Buffer(int _i_size)
    //    {
    //        size = _i_size;
    //        Data = new byte[_i_size];
    //    }
    //    private int size; //缓冲区大小
    //    private int len=0;//已接收数据长度
    //    private bool iscomplete = false;  //接受完成标识
    //    /// <summary>
    //    /// 数据
    //    /// </summary>
    //    public byte[] Data { get; set; }

    //    /// <summary>
    //    /// 获取数据长度
    //    /// </summary>
    //    public int Length
    //    {
    //        get { return len; }
    //    }

    //    /// <summary>
    //    /// 返回格式化的字符串
    //    /// </summary>
    //    /// <returns></returns>
    //    public override string ToString()
    //    {
    //        return Encoding.Default.GetString(Data);
    //    }

    //    /// <summary>
    //    /// 追加字节
    //    /// </summary>
    //    /// <param name="_b_add"></param>
    //    /// <param name="_i_len"></param>
    //    /// <returns></returns>
    //    public int Append(byte[] _b_add,int _i_len)
    //    {
    //        if (len + _i_len > size)    //已超过缓冲区大小
    //            return 0;
    //        for (int i = 0; i < _i_len; i++)
    //        {
    //            Data[len + i] = _b_add[i];
    //        }
    //        len += _i_len;
    //        return _i_len;
    //    }
    //    /// <summary>
    //    /// 清空数组
    //    /// </summary>
    //    public void Clear()
    //    {
    //        Data = new byte[size];
    //        len = 0;
    //    }

    //    /// <summary>
    //    /// 设置或获取接收完成标识
    //    /// </summary>
    //    public bool IsComplete
    //    {
    //        get { return iscomplete; }
    //        set { iscomplete = value; }
    //    }
    //    /// <summary>
    //    /// 读取数据
    //    /// </summary>
    //    /// <returns></returns>
    //    public byte[] Read()
    //    {
    //        byte[] _b_ls = new byte[len];
    //        for (int i=0; i < len; i++)
    //        {
    //            _b_ls[i] = Data[i];
    //        }
    //        Clear();
    //        iscomplete = false;
    //        return _b_ls;
    //    }
    //}

    /// <summary>
    /// 硬件信息
    /// </summary>
    public class Hardware_Info
    {
        /// <summary>
        /// 支持的指令列表
        /// </summary>
        public byte[] Support_CMD { get; set; }
        /// <summary>
        /// BL版本号
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 芯片PID
        /// </summary>
        public string PID { get; set; }
        /// <summary>
        /// 芯片全球唯一序列号
        /// </summary>
        public string Chip_ID { get; set; }
        /// <summary>
        /// 芯片FLASH容量
        /// </summary>
        public int Flash_Size { get; set; }
        /// <summary>
        /// 用户选项字节
        /// </summary>
        public string Option_Byte { get; set; }
    }  
}
