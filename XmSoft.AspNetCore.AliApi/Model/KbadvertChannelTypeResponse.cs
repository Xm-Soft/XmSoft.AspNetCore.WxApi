using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbadvertChannelTypeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbadvertChannelTypeResponse : AliApiObject
    {
        /// <summary>
        /// 渠道描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 排序，暂时无用
        /// </summary>
        [XmlElement("order")]
        public string Order { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
