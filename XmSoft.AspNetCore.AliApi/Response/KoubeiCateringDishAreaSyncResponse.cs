using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishAreaSyncResponse.
    /// </summary>
    public class KoubeiCateringDishAreaSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 餐区餐台模型
        /// </summary>
        [XmlElement("kb_dish_area")]
        public KbdishAreaInfo KbDishArea { get; set; }
    }
}
