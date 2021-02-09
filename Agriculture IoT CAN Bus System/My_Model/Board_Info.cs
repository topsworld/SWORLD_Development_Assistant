using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Model
{
    /// <summary>
    /// 芯片信息
    /// </summary>
    public class Chip
    {
        /// <summary>
        /// 支持的指令列表
        /// </summary>
        public byte[] Support_CMD { get; set; }
        /// <summary>
        /// BL版本号
        /// </summary>
        public string BL_Version { get; set; }
        /// <summary>
        /// 芯片PID
        /// </summary>
        public string PID { get; set; }
        /// <summary>
        /// 芯片全球唯一序列号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 芯片FLASH容量
        /// </summary>
        public int Flash_Size { get; set; }
        /// <summary>
        /// 用户选项字节
        /// </summary>
        public string Option_Byte { get; set; }
        

    }
    //【注】为了证明已存在相关固件信息，需要在地址：0x08005000处写入一组特定的14字节序列
    //序列为：www.sworld.ltd
    // 板信息存储
    //ROW：
    //起始地址：0x08005000
    //空间大小：0x1000    4K
    /// <summary>
    /// 固件信息
    /// </summary>
    public class Firmware
    {
        public static byte[] Adress_Name = new byte[] { 0x08, 0x00, 0x50, 0x10 };
        public static int Len_Name = 2;
        public static byte[] Adress_Net_Serial = new byte[] { 0x08, 0x00, 0x50, 0x20 };
        public static int Len_Net_Serial = 16;
        public static byte[] Adress_Version = new byte[] { 0x08, 0x00, 0x50, 0x30 };
        public static int Len_Version = 12;
        public static byte[] Adress_Time = new byte[] { 0x08, 0x00, 0x50, 0x40 };
        public static int Len_Time = 10;
        public static byte[] Adress_PrjID = new byte[] { 0x08, 0x00, 0x50, 0x50 };
        public static int Len_PrjID = 8;
        public static byte[] Adress_NodeType = new byte[] { 0x08, 0x00, 0x50, 0x80 };
        public static int Len_NodeType = 2;
        public static byte[] Adress_PollingTime = new byte[] { 0x08, 0x00, 0x50, 0x88 };
        public static int Len_PollingTime = 2;
        /// <summary>
        /// 固件名称ID
        /// 大小：2字节
        /// 存储地址：0x08005010
        /// 通过对应表获取详细名称
        /// 格式0x0000
        /// </summary>
        public string Group_ID { get; set; }
        /// <summary>
        /// 固件名称
        /// </summary>
        public string Group_Name { get; set; }
        /// <summary>
        /// 固件中文名称
        /// </summary>
        public string Group_Name_CN { get; set; }
        /// <summary>
        /// 固件类型编码
        /// </summary>
        public string Type_ID { get; set; }
        /// <summary>
        /// 固件入网序列（仅无线通讯类型固件具有）
        /// 大小：16字节
        /// 存储地址：0x08005020
        /// </summary>
        public string Net_Serial { get; set; }
        /// <summary>
        /// 固件版本
        /// 大小：12字节
        /// 存储地址：0x08005030
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 固件更新时间
        /// 大小：10字节
        /// 存储地址：0x08005040
        /// </summary>
        public string Time { get; set; }
        /// <summary>
        /// 固件项目编号
        /// 大小：8字节
        /// 存储地址：0x08005050
        /// </summary>
        public string Prj_ID { get; set; }
        /// <summary>
        /// 节点类型
        /// 大小：2字节
        /// 存储地址：0x08005080
        /// </summary>
        public string Node_Type { get; set; }
        /// <summary>
        /// 轮询时间
        /// 大小：2字节
        /// 存储地址：0x08005088
        /// </summary>
        public UInt16 Polling_Time { get; set; }
        public string Size { get; set; }
    }

    /// <summary>
    /// SWorld BootLoader信息
    /// </summary>
    public class SWBL
    {
        public static byte[] Adress_Version = new byte[] { 0x08, 0x00, 0x50, 0x60 };
        public static int Len_Version = 5;
        public static byte[] Adress_Time = new byte[] { 0x08, 0x00, 0x50, 0x70 };
        public static int Len_Time = 10;
        /// <summary>
        /// SWBL版本号（V1.0L=V1.0 Lite）
        /// 大小：5字节
        /// 存储地址：0x08005060
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// SWBL更新时间
        /// 大小：10字节
        /// 存储地址：0x08005070
        /// </summary>
        public string Time { get; set; }        
    }
}
