using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PriceInfo : AliApiObject
    {
        /// <summary>
        /// 商品价格维度信息
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 价格，单位为元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
