using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskPolicyRdsQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskPolicyRdsQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 人机识别结果。返回HUMAN表示识别结果为人；返回ROBOT表示识别结果为机器。
        /// </summary>
        [XmlElement("rds_result")]
        public string RdsResult { get; set; }
    }
}
