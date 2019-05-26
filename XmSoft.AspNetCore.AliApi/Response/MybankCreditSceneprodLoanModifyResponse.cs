using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditSceneprodLoanModifyResponse.
    /// </summary>
    public class MybankCreditSceneprodLoanModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 在特定状态修改完毕后的返回内容，里面包含合作机构推进流程的信息。
        /// </summary>
        [XmlElement("result_content")]
        public string ResultContent { get; set; }

        /// <summary>
        /// 是否重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
