using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsSceneProductAgreementCancelResponse.
    /// </summary>
    public class AlipayInsSceneProductAgreementCancelResponse : AliApiResponse
    {
        /// <summary>
        /// 返回成功或者失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
