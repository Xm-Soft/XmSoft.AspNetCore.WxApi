using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayTradeOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeOrderPayModel : AliApiObject
    {
        /// <summary>
        /// 买家的支付宝用户id    注：  1.用于校验与已存交易中的买家是否相等
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付明细    目前支持的支付渠道为：  - offline_pos：本次买家使用的是pos刷卡支付    注：  各支付工具金额总和=订单总金额
        /// </summary>
        [XmlArray("buyer_pay_detail")]
        [XmlArrayItem("buyer_pay_detail")]
        public List<BuyerPayDetail> BuyerPayDetail { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]    注：  1.用于校验与已存交易中的金额是否相等
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
