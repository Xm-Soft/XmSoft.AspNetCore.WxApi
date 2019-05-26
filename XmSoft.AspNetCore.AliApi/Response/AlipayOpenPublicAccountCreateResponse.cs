using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicAccountCreateResponse.
    /// </summary>
    public class AlipayOpenPublicAccountCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 协议号，商户会员在支付宝服务窗账号中的唯一标识
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }
    }
}
