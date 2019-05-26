using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserCharityForestsendpicSendResponse.
    /// </summary>
    public class AlipayUserCharityForestsendpicSendResponse : AliApiResponse
    {
        /// <summary>
        /// 结果代码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果文案
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 是否上传成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
