using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayWeiboTokenGetResponse.
    /// </summary>
    public class AlipayWeiboTokenGetResponse : AliApiResponse
    {
        /// <summary>
        /// 访问账单查询的临时令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }
    }
}
