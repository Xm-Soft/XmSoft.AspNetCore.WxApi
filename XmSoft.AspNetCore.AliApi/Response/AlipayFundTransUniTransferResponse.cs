using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayFundTransUniTransferResponse.
    /// </summary>
    public class AlipayFundTransUniTransferResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转账单据状态。   SUCCESS：成功（对转账到银行卡的单据, 该状态可能变为退票[REFUND]状态）；   FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）；   DEALING：处理中；   REFUND：退票；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
