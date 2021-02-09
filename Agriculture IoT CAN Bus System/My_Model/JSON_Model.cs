using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Model
{
    [DataContract]
    public class Common_Version
    {
        
        /// <summary>
        /// 固件版本号
        /// </summary>
        [DataMember]
        public string col_Version { get; set; }
        /// <summary>
        /// 固件大小
        /// </summary>
        [DataMember]
        public string col_Size { get; set; }
        /// <summary>
        /// 固件更新时间
        /// </summary>
        [DataMember]
        public string col_Time { get; set; }
        /// <summary>
        /// 文件MD5值
        /// </summary>
        [DataMember]
        public string MD5 { get; set; }
        /// <summary>
        /// 文件SHA1值
        /// </summary>
        [DataMember]
        public string SHA1 { get; set; }
        public override string ToString()
        {
            return col_Version;
        }
       
    }
    [DataContract]
    public class Program_Version
    {
        /// <summary>
        /// 固件类型编码
        /// 板类型编码
        /// </summary>
        [DataMember]
        public string type_ID { get; set; }
        /// <summary>
        /// 固件ID
        /// 板基础CAN ID
        /// </summary>
        [DataMember]
        public string group_ID { get; set; }
        /// <summary>
        /// 固件名称
        /// 固件编译名称
        /// </summary>
        [DataMember]
        public string group_Name { get; set; }
        /// <summary>
        /// 固件中文名称
        /// </summary>
        [DataMember]
        public string group_Name_CN { get; set; }
        /// <summary>
        /// 固件传感器名称
        /// </summary>
        [DataMember]
        public string group_Sensor { get; set; }
        /// <summary>
        /// 固件版本列表
        /// </summary>
        [DataMember]
        public List<Common_Version> Info { get; set; }
        public override string ToString()
        {
            return type_ID + "-"+group_Name_CN;
        }
    }

    [DataContract]
    public class Type_Info
    {
        /// <summary>
        /// 类型ID
        /// </summary>
        [DataMember]
        public string type_ID { get; set; }
        /// <summary>
        /// 类型编码
        /// </summary>
        [DataMember]
        public string type_Name { get; set; }
        public override string ToString()
        {
            return type_ID+"-"+type_Name;
        }
    }

    [DataContract]
    public class Version_Config
    {
        /// <summary>
        /// 类型字典
        /// </summary>
        [DataMember]
        public List<Type_Info> Type_List { get; set; }
        /// <summary>
        /// 引导固件
        /// </summary>
        [DataMember]
        public Program_Version BootLoader { get; set; }
        /// <summary>
        /// 程序
        /// </summary>
        [DataMember]
        public List<Program_Version> Program { get; set; }
    }
}
