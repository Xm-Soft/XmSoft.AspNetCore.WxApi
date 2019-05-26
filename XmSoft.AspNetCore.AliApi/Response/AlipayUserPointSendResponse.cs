using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserPointSendResponse.
    /// </summary>
    public class AlipayUserPointSendResponse : AliApiResponse
    {
        /// <summary>
        /// 实际给用户发放的积分数，由于单个用户有日限额，所以实际发放的积分数可能小于请求发放的积分数
        /// </summary>
        [XmlElement("send_point")]
        public long SendPoint { get; set; }
    }
}
