using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Model
{
    [DataContract]
    public class Sys_Config
    {
        /// <summary>
        /// 首次运行标识
        /// </summary>
        [DataMember]
        public bool First_Run_Flag { get; set; }
        /// <summary>
        /// 波特率
        /// </summary>
        [DataMember]
        public int BaudRate { get; set; }
        /// <summary>
        /// BL下载地址
        /// </summary>
        [DataMember]
        public string BL_DL_Address { get; set; }
        /// <summary>
        /// 固件下载地址
        /// </summary>
        [DataMember]
        public string Firmware_DL_Address { get; set; }
        /// <summary>
        /// 系统运行地址
        /// </summary>
        [DataMember]
        public string Sys_Run_Address { get; set; }
        /// <summary>
        /// 消息显示时间戳
        /// </summary>
        [DataMember]
        public bool Msg_Show_Time { get; set; }
        /// <summary>
        /// 下载校验
        /// </summary>
        [DataMember]
        public bool DL_Check { get; set; }
        /// <summary>
        /// 下载后直接运行
        /// </summary>
        [DataMember]
        public bool DL_Dir_Run { get; set; }
        /// <summary>
        /// 启动时检查更新
        /// </summary>
        [DataMember]
        public bool Start_Check_Update { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        [DataMember]
        public string Login_Name { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [DataMember]
        public string Login_PWD { get; set; }
    }
}
