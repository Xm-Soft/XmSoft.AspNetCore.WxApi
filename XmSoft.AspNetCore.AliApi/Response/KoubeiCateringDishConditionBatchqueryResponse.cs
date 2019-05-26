using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishConditionBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringDishConditionBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 菜品分页信息
        /// </summary>
        [XmlElement("kb_dish_page_info")]
        public PaginationDish KbDishPageInfo { get; set; }
    }
}
