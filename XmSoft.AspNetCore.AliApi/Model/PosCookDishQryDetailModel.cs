using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PosCookDishQryDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosCookDishQryDetailModel : AliApiObject
    {
        /// <summary>
        /// 菜品对应的售卖类别的ID
        /// </summary>
        [XmlElement("category_big_id")]
        public string CategoryBigId { get; set; }

        /// <summary>
        /// 菜品的ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品素材库的ID
        /// </summary>
        [XmlElement("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名字
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品的最低售卖价格
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// true false 是否是多规格
        /// </summary>
        [XmlElement("multi_spec")]
        public bool MultiSpec { get; set; }

        /// <summary>
        /// 新品或者招牌 标签
        /// </summary>
        [XmlElement("special_tag")]
        public string SpecialTag { get; set; }

        /// <summary>
        /// 辣度
        /// </summary>
        [XmlElement("spicy_tag")]
        public string SpicyTag { get; set; }

        /// <summary>
        /// 菜品的售卖状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 菜品的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 菜品单位
        /// </summary>
        [XmlElement("unit_name")]
        public string UnitName { get; set; }
    }
}
