using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// InsMktFactorDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktFactorDTO : AliApiObject
    {
        /// <summary>
        /// 规则因子
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 规则因子值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
