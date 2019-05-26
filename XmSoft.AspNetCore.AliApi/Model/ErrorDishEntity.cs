using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ErrorDishEntity Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorDishEntity : AliApiObject
    {
        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }
    }
}
