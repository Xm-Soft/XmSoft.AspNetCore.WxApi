using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRetailDmSetResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRetailDmSetResponse : AliApiResponse
    {
        /// <summary>
        /// 内容ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }
    }
}
