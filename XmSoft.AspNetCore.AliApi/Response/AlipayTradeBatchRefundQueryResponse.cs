using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayTradeBatchRefundQueryResponse.
    /// </summary>
    public class AlipayTradeBatchRefundQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 退款明细信息
        /// </summary>
        [XmlArray("result_details")]
        [XmlArrayItem("batch_refund_detail_result")]
        public List<BatchRefundDetailResult> ResultDetails { get; set; }
    }
}
