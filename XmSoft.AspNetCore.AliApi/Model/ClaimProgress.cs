using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ClaimProgress Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimProgress : AliApiObject
    {
        /// <summary>
        /// 更新内容
        /// </summary>
        [XmlElement("update_content")]
        public string UpdateContent { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
