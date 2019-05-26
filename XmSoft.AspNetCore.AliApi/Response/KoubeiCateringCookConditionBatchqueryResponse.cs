using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringCookConditionBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringCookConditionBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑菜谱模型列表
        /// </summary>
        [XmlElement("kb_dish_cook_page_info")]
        public PaginationCook KbDishCookPageInfo { get; set; }
    }
}
