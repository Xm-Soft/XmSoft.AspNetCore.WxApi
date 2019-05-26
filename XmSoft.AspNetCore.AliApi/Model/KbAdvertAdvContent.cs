using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbAdvertAdvContent Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertAdvContent : AliApiObject
    {
        /// <summary>
        /// 二维码
        /// </summary>
        [XmlElement("codec")]
        public string Codec { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }
    }
}
