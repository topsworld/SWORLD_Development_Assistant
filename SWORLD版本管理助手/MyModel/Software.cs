using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SWORLD版本管理助手.MyModel
{
    [DataContract]
    public class Software
    {
        /// <summary>
        /// 软件编码（存放文件夹名）
        /// </summary>
        [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 软件名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 添加日期
        /// </summary>
        [DataMember]
        public DateTime AddDate { get; set; }
        /// <summary>
        /// 和服务器同步状态
        /// </summary>
        [DataMember]
        public bool Sync { get; set; }
        /// <summary>
        /// 版本信息
        /// </summary>
        [DataMember]
        public List<Version> Versions { get; set; }
    }
}
