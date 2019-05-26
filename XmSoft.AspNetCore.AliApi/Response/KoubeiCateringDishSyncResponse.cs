using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishSyncResponse.
    /// </summary>
    public class KoubeiCateringDishSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 返回的菜品模型
        /// </summary>
        [XmlElement("kb_dish_info")]
        public KbdishInfo KbDishInfo { get; set; }
    }
}
