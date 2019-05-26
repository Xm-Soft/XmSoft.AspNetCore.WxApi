using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringDishMaterialCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMaterialCreateModel : AliApiObject
    {
        /// <summary>
        /// 菜品加料入参
        /// </summary>
        [XmlElement("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
