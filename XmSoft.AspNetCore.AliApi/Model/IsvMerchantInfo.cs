using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// IsvMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IsvMerchantInfo : AliApiObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店ID列表
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
