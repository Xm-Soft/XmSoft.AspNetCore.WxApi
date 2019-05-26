using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoAcceptanceRequestCreateResponse.
    /// </summary>
    public class AlipayEcoAcceptanceRequestCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 提交数据ID
        /// </summary>
        [XmlElement("request_id")]
        public long RequestId { get; set; }

        /// <summary>
        /// 结果记录条数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
