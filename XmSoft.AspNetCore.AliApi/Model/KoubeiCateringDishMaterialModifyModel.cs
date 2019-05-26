using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringDishMaterialModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMaterialModifyModel : AliApiObject
    {
        /// <summary>
        /// 菜品加料入参
        /// </summary>
        [XmlElement("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
