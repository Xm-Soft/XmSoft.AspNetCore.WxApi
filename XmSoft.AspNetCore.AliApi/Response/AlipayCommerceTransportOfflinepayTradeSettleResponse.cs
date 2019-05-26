using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayTradeSettleResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayTradeSettleResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝脱机交易处理结果列表
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("alipay_offline_trade_result")]
        public List<AlipayOfflineTradeResult> ResultList { get; set; }
    }
}
