using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserCertifyActionApplyResponse.
    /// </summary>
    public class AlipayUserCertifyActionApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 返回给商户的支付宝业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
