using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 身份安全业务相关查询业务信息
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }
    }
}
