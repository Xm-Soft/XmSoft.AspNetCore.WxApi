using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherOfflineResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherOfflineResponse : AliApiResponse
    {
        /// <summary>
        /// 券模板编号
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券模板状态。EFFECTIVE=生效，INVALID=失效。
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
