using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityInfoAnalysisResponse.
    /// </summary>
    public class AlipaySecurityInfoAnalysisResponse : AliApiResponse
    {
        /// <summary>
        /// 风险标签
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_level")]
        public long RiskLevel { get; set; }
    }
}
