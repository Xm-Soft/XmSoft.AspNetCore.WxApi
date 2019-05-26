using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDatabizCorePaymentAbilityGetResponse.
    /// </summary>
    public class AlipayDatabizCorePaymentAbilityGetResponse : AliApiResponse
    {
        /// <summary>
        /// 支付能力返回结果信息
        /// </summary>
        [XmlElement("payment_ability_query_response")]
        public PaymentAbilityQueryResponse PaymentAbilityQueryResponse { get; set; }
    }
}
