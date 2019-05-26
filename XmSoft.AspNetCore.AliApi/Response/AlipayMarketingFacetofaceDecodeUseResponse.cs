using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingFacetofaceDecodeUseResponse.
    /// </summary>
    public class AlipayMarketingFacetofaceDecodeUseResponse : AliApiResponse
    {
        /// <summary>
        /// 用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
