using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosDishBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringPosDishBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 菜谱中的菜品的列表
        /// </summary>
        [XmlElement("cook_dish")]
        public PosCookDishQryModel CookDish { get; set; }
    }
}
