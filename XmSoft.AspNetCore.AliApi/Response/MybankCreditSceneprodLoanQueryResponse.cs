using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditSceneprodLoanQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodLoanQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 对于订单信息需要说明的内容
        /// </summary>
        [XmlElement("desc_msg")]
        public string DescMsg { get; set; }

        /// <summary>
        /// 返回当前订单的信息
        /// </summary>
        [XmlElement("info")]
        public string Info { get; set; }

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
