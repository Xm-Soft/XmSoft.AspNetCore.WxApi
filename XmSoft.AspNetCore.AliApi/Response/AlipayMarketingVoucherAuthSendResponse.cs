using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingVoucherAuthSendResponse.
    /// </summary>
    public class AlipayMarketingVoucherAuthSendResponse : AliApiResponse
    {
        /// <summary>
        /// 券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
