using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcapiprodCreditGetResponse.
    /// </summary>
    public class AlipayEcapiprodCreditGetResponse : AliApiResponse
    {
        /// <summary>
        /// 授信结果
        /// </summary>
        [XmlElement("credit_result")]
        public CreditResult CreditResult { get; set; }

        /// <summary>
        /// 为了保持幂等性，返回唯一请求号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
