using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsSceneProductSignConfirmResponse.
    /// </summary>
    public class AlipayInsSceneProductSignConfirmResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
