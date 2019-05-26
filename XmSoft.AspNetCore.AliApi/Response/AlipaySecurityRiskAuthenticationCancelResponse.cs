using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationCancelResponse.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationCancelResponse : AliApiResponse
    {
        /// <summary>
        /// 返回取消结果
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }
    }
}
