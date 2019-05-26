using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayFundTransTrusteeshipAccountCreateResponse.
    /// </summary>
    public class AlipayFundTransTrusteeshipAccountCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 开设的支付宝账号user_id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
