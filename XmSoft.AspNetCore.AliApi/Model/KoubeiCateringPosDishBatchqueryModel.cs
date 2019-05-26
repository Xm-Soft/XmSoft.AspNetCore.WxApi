using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosDishBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 菜谱的ID
        /// </summary>
        [XmlElement("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 按照菜品名字模糊查询菜谱下的菜品
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
