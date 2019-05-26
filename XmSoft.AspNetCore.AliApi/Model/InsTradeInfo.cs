using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// InsTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsTradeInfo : AliApiObject
    {
        /// <summary>
        /// 产品编码  交强险-01010000002000000251,   商业险-01010000002000000250
        /// </summary>
        [XmlElement("product_no")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 车险内部订单号
        /// </summary>
        [XmlElement("trade_biz_id")]
        public string TradeBizId { get; set; }
    }
}
