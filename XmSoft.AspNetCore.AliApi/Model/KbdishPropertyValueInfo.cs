using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbdishPropertyValueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishPropertyValueInfo : AliApiObject
    {
        /// <summary>
        /// 属性值排序字段，从1一直递增到5
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 销售属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
