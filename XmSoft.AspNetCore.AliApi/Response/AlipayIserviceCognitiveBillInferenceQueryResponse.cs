using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveBillInferenceQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveBillInferenceQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 发票识别内容详细信息
        /// </summary>
        [XmlElement("result")]
        public BillInferenceResult Result { get; set; }

        /// <summary>
        /// 信息抽取是否抽取成功
        /// </summary>
        [XmlElement("ret")]
        public long Ret { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
