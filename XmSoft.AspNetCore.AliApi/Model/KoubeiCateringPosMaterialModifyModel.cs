using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosMaterialModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosMaterialModifyModel : AliApiObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配料名称
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
