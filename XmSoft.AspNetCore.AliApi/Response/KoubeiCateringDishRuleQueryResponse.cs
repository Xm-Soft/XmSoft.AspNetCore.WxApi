using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishRuleQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRuleQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 规则的返回集合
        /// </summary>
        [XmlArray("kb_dish_rule_info_list")]
        [XmlArrayItem("kbdish_rule_info")]
        public List<KbdishRuleInfo> KbDishRuleInfoList { get; set; }
    }
}
