using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveImageRouteQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveImageRouteQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误详细描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 业务识别内容
        /// </summary>
        [XmlElement("res")]
        public string Res { get; set; }

        /// <summary>
        /// true: 成功  false:失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
