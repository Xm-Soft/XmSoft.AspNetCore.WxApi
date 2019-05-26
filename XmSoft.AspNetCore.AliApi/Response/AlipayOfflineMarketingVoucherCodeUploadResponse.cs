using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherCodeUploadResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherCodeUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 码库id
        /// </summary>
        [XmlElement("code_inventory_id")]
        public string CodeInventoryId { get; set; }
    }
}
