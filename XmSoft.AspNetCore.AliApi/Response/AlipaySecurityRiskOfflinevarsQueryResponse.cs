using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskOfflinevarsQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskOfflinevarsQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询结果，包含所有维度的结果数据，两层json格式
        /// </summary>
        [XmlElement("query_result")]
        public string QueryResult { get; set; }

        /// <summary>
        /// 调用是否成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
