using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskPolicyQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskPolicyQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 是否出二次核身的标识
        /// </summary>
        [XmlElement("has_to_check")]
        public bool HasToCheck { get; set; }

        /// <summary>
        /// 风险咨询情况下返回的风险等级，风险处理不会返回该值
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 查询是否成功
        /// </summary>
        [XmlElement("query_success")]
        public bool QuerySuccess { get; set; }

        /// <summary>
        /// 安全请求生成的唯一ID
        /// </summary>
        [XmlElement("security_id")]
        public string SecurityId { get; set; }

        /// <summary>
        /// 是否成功，本版本废弃
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 有风险需要失败业务情况下的返回码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 有风险需要失败业务情况下的返回码描述
        /// </summary>
        [XmlElement("template_desc")]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// native场景下的核身id
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }

        /// <summary>
        /// h5场景下的核身地址
        /// </summary>
        [XmlElement("verify_url")]
        public string VerifyUrl { get; set; }
    }
}
