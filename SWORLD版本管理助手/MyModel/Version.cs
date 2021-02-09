using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SWORLD版本管理助手.MyModel
{
    [DataContract]
    public class Version
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [DataMember]
        public string VersionNum { get; set; }
        /// <summary>
        /// 更新内容
        /// </summary>
        [DataMember]
        public string UpdateContent { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        [DataMember]
        public DateTime AddDate { get; set; }
        /// <summary>
        /// 同步状态
        /// </summary>
        [DataMember]
        public bool Sync { get; set; }
        /// <summary>
        /// MD5加密
        /// </summary>
        [DataMember]
        public string MD5 { get; set; }

    }
}
