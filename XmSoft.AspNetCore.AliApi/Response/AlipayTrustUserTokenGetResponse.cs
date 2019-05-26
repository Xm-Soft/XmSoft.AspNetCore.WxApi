using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayTrustUserTokenGetResponse.
    /// </summary>
    public class AlipayTrustUserTokenGetResponse : AliApiResponse
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 本字段已废弃
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
