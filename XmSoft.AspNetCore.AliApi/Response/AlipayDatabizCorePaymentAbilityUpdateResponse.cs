using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDatabizCorePaymentAbilityUpdateResponse.
    /// </summary>
    public class AlipayDatabizCorePaymentAbilityUpdateResponse : AliApiResponse
    {
        /// <summary>
        /// 支付能力回传信息结果信息
        /// </summary>
        [XmlElement("payment_ability_postback_response")]
        public PaymentAbilityPostbackResponse PaymentAbilityPostbackResponse { get; set; }
    }
}
