using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardcontentSendResponse.
    /// </summary>
    public class AlipaySocialBaseContentlibStandardcontentSendResponse : AliApiResponse
    {
        /// <summary>
        /// result_msg为请求openAPI接口后返回的结果message
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
