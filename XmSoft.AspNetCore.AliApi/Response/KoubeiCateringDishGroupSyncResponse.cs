using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishGroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishGroupSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 组模型
        /// </summary>
        [XmlElement("kb_dish_group")]
        public KbdishGroupInfo KbDishGroup { get; set; }
    }
}
