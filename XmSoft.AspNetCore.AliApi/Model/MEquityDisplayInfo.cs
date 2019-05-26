using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MEquityDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MEquityDisplayInfo : AliApiObject
    {
        /// <summary>
        /// 品牌名
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 权益LOGO
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
