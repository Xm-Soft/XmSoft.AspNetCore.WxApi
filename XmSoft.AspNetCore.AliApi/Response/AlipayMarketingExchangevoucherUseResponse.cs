using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingExchangevoucherUseResponse.
    /// </summary>
    public class AlipayMarketingExchangevoucherUseResponse : AliApiResponse
    {
        /// <summary>
        /// 被核销的券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
