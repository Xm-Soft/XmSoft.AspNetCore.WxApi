using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishCookSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCookSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 操作后返回整个模型
        /// </summary>
        [XmlElement("kb_dish_cook")]
        public KbdishCookInfo KbDishCook { get; set; }
    }
}
