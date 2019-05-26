using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishQueryResponse.
    /// </summary>
    public class KoubeiCateringDishQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑菜品模型列表
        /// </summary>
        [XmlArray("kb_dish_info_list")]
        [XmlArrayItem("kbdish_info")]
        public List<KbdishInfo> KbDishInfoList { get; set; }
    }
}
