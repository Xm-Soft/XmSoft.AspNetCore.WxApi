using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserCertifyOpenInitializeResponse.
    /// </summary>
    public class AlipayUserCertifyOpenInitializeResponse : AliApiResponse
    {
        /// <summary>
        /// 本次申请操作的唯一标识，商户需要记录，后续的操作都需要用到
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
