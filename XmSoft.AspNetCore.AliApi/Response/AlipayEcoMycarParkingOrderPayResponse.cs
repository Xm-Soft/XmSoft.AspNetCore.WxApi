using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderPayResponse.
    /// </summary>
    public class AlipayEcoMycarParkingOrderPayResponse : AliApiResponse
    {
        /// <summary>
        /// 本次交易使用的支付渠道信息。详见（支付渠道信息）
        /// </summary>
        [XmlElement("fund_bill_list")]
        public string FundBillList { get; set; }

        /// <summary>
        /// 该笔交易的买家付款时间。  格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 对应商户网站的订单系统中的唯一订单号，非支付宝交易号。  需保证在商户网站中的唯一性。是请求时对应的参数，原样返回。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易金额  保留小数点后两位
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。系统唯一，最短16位，最长64位
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 买家支付宝用户ID，用于标识订单扣款用户及订单回传使用
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
