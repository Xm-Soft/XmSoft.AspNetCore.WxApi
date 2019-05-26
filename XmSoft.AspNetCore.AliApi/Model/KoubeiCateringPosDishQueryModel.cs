using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosDishQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishQueryModel : AliApiObject
    {
        /// <summary>
        /// 菜品的ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 门店的ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
