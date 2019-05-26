using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishCookQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCookQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 菜谱list
        /// </summary>
        [XmlArray("kb_cook_list")]
        [XmlArrayItem("kbdish_cook_info")]
        public List<KbdishCookInfo> KbCookList { get; set; }
    }
}
