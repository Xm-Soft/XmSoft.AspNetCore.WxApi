using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }
    }
}
