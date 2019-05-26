using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffOrdersresultSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffOrdersresultSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 物料单据反馈结果
        /// </summary>
        [XmlArray("orders_feedback_result")]
        [XmlArrayItem("access_orders_feed_back_result")]
        public List<AccessOrdersFeedBackResult> OrdersFeedbackResult { get; set; }
    }
}
