using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ExtBrand Data Structure.
    /// </summary>
    [Serializable]
    public class ExtBrand : AliApiObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
