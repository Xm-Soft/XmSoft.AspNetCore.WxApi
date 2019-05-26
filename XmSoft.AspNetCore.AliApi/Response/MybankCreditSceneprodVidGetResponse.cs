using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditSceneprodVidGetResponse.
    /// </summary>
    public class MybankCreditSceneprodVidGetResponse : AliApiResponse
    {
        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 支付宝核身VID
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
