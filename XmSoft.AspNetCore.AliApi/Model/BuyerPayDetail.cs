using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// BuyerPayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BuyerPayDetail : AliApiObject
    {
        /// <summary>
        /// 买家支付金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }
    }
}
