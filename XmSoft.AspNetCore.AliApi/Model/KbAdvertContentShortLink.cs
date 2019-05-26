using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbAdvertContentShortLink Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentShortLink : AliApiObject
    {
        /// <summary>
        /// 链接地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
