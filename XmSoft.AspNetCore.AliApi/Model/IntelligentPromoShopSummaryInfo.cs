using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// IntelligentPromoShopSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntelligentPromoShopSummaryInfo : AliApiObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 全店名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
