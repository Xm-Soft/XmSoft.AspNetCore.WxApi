using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataActivityBillDownloadResponse.
    /// </summary>
    public class KoubeiMarketingDataActivityBillDownloadResponse : AliApiResponse
    {
        /// <summary>
        /// 账单下载地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
