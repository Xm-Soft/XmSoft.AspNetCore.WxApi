using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataEnterpriseStaffinfoUploadResponse.
    /// </summary>
    public class KoubeiMarketingDataEnterpriseStaffinfoUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 人群ID
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }
    }
}
