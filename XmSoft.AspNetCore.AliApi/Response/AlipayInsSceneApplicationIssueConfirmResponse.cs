using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationIssueConfirmResponse.
    /// </summary>
    public class AlipayInsSceneApplicationIssueConfirmResponse : AliApiResponse
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }
    }
}
