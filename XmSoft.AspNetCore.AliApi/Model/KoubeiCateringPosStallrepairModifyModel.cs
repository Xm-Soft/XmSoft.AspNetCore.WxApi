using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosStallrepairModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosStallrepairModifyModel : AliApiObject
    {
        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 档口id
        /// </summary>
        [XmlElement("stall_id")]
        public string StallId { get; set; }
    }
}
