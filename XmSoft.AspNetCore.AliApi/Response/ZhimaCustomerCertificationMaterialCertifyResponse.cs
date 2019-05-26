using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationMaterialCertifyResponse.
    /// </summary>
    public class ZhimaCustomerCertificationMaterialCertifyResponse : AliApiResponse
    {
        /// <summary>
        /// 本次认证的唯一标识，商户需要记录，后续的操作都需要用到
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [XmlElement("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证是否通过,通过为true，不通过为false
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
