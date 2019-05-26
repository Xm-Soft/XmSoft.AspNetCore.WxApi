using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayGotoneMessageCourierSendResponse.
    /// </summary>
    public class AlipayGotoneMessageCourierSendResponse : AliApiResponse
    {
        /// <summary>
        /// 结果码。SUCCESS：发送成功。
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
