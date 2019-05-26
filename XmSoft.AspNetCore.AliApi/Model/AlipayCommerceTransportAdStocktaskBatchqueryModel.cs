using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdStocktaskBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 用户id+根据用户id批量查询该用户提交的库存查询任务
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }
    }
}
