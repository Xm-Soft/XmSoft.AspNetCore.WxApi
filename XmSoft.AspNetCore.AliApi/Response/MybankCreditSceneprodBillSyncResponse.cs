using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditSceneprodBillSyncResponse.
    /// </summary>
    public class MybankCreditSceneprodBillSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
