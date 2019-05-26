using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserAntpaasUseridGetResponse.
    /// </summary>
    public class AlipayUserAntpaasUseridGetResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
