using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayTradeSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOfflinepayTradeSettleModel : AliApiObject
    {
        /// <summary>
        /// 脱机交易列表
        /// </summary>
        [XmlArray("trade_list")]
        [XmlArrayItem("alipay_offline_trade")]
        public List<AlipayOfflineTrade> TradeList { get; set; }
    }
}
