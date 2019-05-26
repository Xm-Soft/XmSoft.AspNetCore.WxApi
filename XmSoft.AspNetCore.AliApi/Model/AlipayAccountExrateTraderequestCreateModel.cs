using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayAccountExrateTraderequestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateTraderequestCreateModel : AliApiObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [XmlElement("trade_request")]
        public TradeRequestVO TradeRequest { get; set; }
    }
}
