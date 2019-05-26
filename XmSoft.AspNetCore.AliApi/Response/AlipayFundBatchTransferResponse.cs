using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayFundBatchTransferResponse.
    /// </summary>
    public class AlipayFundBatchTransferResponse : AliApiResponse
    {
        /// <summary>
        /// 商户请求的批次流水号，同请求中的"batch_no"。
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 支付宝系统内部批次请求id。
        /// </summary>
        [XmlElement("batch_trans_id")]
        public string BatchTransId { get; set; }
    }
}
