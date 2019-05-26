using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityConfirmResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityConfirmResponse : AliApiResponse
    {
        /// <summary>
        /// 身份核实校验结果失败时，返回的失败错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 身份核实校验结果失败时，返回的失败错误原因说明
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 身份核验结果
        /// </summary>
        [XmlElement("verify_result")]
        public bool VerifyResult { get; set; }
    }
}
