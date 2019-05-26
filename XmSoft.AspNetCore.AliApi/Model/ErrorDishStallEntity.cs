using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ErrorDishStallEntity Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorDishStallEntity : AliApiObject
    {
        /// <summary>
        /// 未关联档口菜品集合
        /// </summary>
        [XmlArray("no_set_stall")]
        [XmlArrayItem("error_dish_entity")]
        public List<ErrorDishEntity> NoSetStall { get; set; }

        /// <summary>
        /// 重复关联档口菜品集合
        /// </summary>
        [XmlArray("repeat_set_stall")]
        [XmlArrayItem("error_dish_entity")]
        public List<ErrorDishEntity> RepeatSetStall { get; set; }
    }
}
