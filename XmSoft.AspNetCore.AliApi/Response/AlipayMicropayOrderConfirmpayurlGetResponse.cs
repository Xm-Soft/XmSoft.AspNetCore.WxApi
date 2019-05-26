using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMicropayOrderConfirmpayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderConfirmpayurlGetResponse : AliApiResponse
    {
        /// <summary>
        /// SinglePayDetail信息
        /// </summary>
        [XmlElement("single_pay_detail")]
        public SinglePayDetail SinglePayDetail { get; set; }
    }
}
