using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsDataAutoCoefficientSyncResponse.
    /// </summary>
    public class AlipayInsDataAutoCoefficientSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 用户唯一请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
