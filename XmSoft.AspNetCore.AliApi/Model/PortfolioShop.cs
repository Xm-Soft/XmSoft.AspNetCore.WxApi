using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PortfolioShop Data Structure.
    /// </summary>
    [Serializable]
    public class PortfolioShop : AliApiObject
    {
        /// <summary>
        /// 展示权重；必须大于等于0；排序规则：权重倒叙
        /// </summary>
        [XmlElement("display_weight")]
        public long DisplayWeight { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
