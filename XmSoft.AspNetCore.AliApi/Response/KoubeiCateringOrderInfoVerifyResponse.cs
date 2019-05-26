using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringOrderInfoVerifyResponse.
    /// </summary>
    public class KoubeiCateringOrderInfoVerifyResponse : AliApiResponse
    {
        /// <summary>
        /// 餐饮订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否需要重试，true-需要，false-不需要
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
