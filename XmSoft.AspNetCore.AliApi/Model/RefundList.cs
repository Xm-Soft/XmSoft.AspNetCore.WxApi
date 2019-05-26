using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// RefundList Data Structure.
    /// </summary>
    [Serializable]
    public class RefundList : AliApiObject
    {
        /// <summary>
        /// 退优惠明细JSON
        /// </summary>
        [XmlArray("discount_infos")]
        [XmlArrayItem("discount_infos")]
        public List<DiscountInfos> DiscountInfos { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// POS退款单ID
        /// </summary>
        [XmlElement("out_refund_id")]
        public string OutRefundId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退优惠的金额
        /// </summary>
        [XmlElement("refund_discount_amount")]
        public string RefundDiscountAmount { get; set; }

        /// <summary>
        /// 口碑退款单ID
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退款方式，包括但不限于：  (1) ONLINE : 线上支付  (2) OFFLINE_ALIPAY：线下支付宝收款  (3) OFFLINE_WECHAT：线下微信支付  (4) OFFLINE_BANKCARD：线下银行卡支付  (5) OFFLINE_CASH : 线下现金支付  (6) OFFLINE_POINTS : 积分支付  (7) OFFLINE_STORED_VALUE_CARD : 储值卡支付  (8) OFFLINE_KOUBEI_VOUCHER : 口碑券  (9) OFFLINE_MEITUAN : 美团  (10) OFFLINE_OTHER : 线下其他支付方式
        /// </summary>
        [XmlElement("refund_method")]
        public string RefundMethod { get; set; }
    }
}
