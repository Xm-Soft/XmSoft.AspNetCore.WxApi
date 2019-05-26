using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ItemExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemExtInfo : AliApiObject
    {
        /// <summary>
        /// 扩展信息的key
        /// </summary>
        [XmlElement("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息的值
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }
    }
}
