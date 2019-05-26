using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdUserCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdUserCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 广告系统用户ID
        /// </summary>
        [XmlElement("ad_user_id")]
        public string AdUserId { get; set; }
    }
}
