using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAuthIndustryPlatformCreateTokenResponse.
    /// </summary>
    public class AlipayOpenAuthIndustryPlatformCreateTokenResponse : AliApiResponse
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [XmlElement("requst_app_id")]
        public string RequstAppId { get; set; }

        /// <summary>
        /// scope
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }
    }
}
