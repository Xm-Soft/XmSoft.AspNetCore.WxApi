using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishGroupQueryResponse.
    /// </summary>
    public class KoubeiCateringDishGroupQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 项目列表
        /// </summary>
        [XmlArray("kb_dish_group_list")]
        [XmlArrayItem("kbdish_group_info")]
        public List<KbdishGroupInfo> KbDishGroupList { get; set; }
    }
}
