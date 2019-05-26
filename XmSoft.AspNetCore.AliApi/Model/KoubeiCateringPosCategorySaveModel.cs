using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosCategorySaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategorySaveModel : AliApiObject
    {
        /// <summary>
        /// 排序菜类列表
        /// </summary>
        [XmlArray("category_entity_list")]
        [XmlArrayItem("dish_category_entity")]
        public List<DishCategoryEntity> CategoryEntityList { get; set; }
    }
}
