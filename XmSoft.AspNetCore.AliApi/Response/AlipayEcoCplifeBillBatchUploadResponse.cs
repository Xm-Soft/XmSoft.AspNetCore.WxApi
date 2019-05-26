using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoCplifeBillBatchUploadResponse.
    /// </summary>
    public class AlipayEcoCplifeBillBatchUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 成功导入所有条目集合中的条目，则回传请求中的批次号
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
