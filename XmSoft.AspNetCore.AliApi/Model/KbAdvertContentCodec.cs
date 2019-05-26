using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbAdvertContentCodec Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentCodec : AliApiObject
    {
        /// <summary>
        /// 二维码广告内容
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
