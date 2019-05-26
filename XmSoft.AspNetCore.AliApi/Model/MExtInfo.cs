using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MExtInfo : AliApiObject
    {
        /// <summary>
        /// 扩展信息key值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展信息value值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
