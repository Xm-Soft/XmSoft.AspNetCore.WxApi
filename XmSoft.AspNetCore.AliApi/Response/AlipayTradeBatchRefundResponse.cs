using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayTradeBatchRefundResponse.
    /// </summary>
    public class AlipayTradeBatchRefundResponse : AliApiResponse
    {
        /// <summary>
        /// 请求的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
