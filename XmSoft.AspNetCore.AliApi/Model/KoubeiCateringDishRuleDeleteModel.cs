using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringDishRuleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishRuleDeleteModel : AliApiObject
    {
        /// <summary>
        /// 菜品规则通用模型
        /// </summary>
        [XmlElement("kb_dish_rule_info")]
        public KbdishRuleInfo KbDishRuleInfo { get; set; }
    }
}
