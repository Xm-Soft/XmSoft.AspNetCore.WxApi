using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserInvitetaskExchangeConsultResponse.
    /// </summary>
    public class AlipayUserInvitetaskExchangeConsultResponse : AliApiResponse
    {
        /// <summary>
        /// true--有兑换资格  false--无兑换资格
        /// </summary>
        [XmlElement("consult_result")]
        public bool ConsultResult { get; set; }
    }
}
