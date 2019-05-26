using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingDataEquitySyncResponse.
    /// </summary>
    public class AlipayMarketingDataEquitySyncResponse : AliApiResponse
    {
        /// <summary>
        /// true/false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
