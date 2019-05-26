using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceLotteryPresentSendResponse.
    /// </summary>
    public class AlipayCommerceLotteryPresentSendResponse : AliApiResponse
    {
        /// <summary>
        /// 是否赠送成功
        /// </summary>
        [XmlElement("send_result")]
        public bool SendResult { get; set; }
    }
}
