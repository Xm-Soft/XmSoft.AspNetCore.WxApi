using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthOrderQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthOrderQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝侧花呗授权操作单据id
        /// </summary>
        [XmlElement("auth_opt_id")]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 业务操作完成时间
        /// </summary>
        [XmlElement("gmt_trans")]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 完成本次操作时，用户资金池余额快照。仅作提示用，请勿用于核对，并发情况下数值有可能不准确。两位小数，单位元。
        /// </summary>
        [XmlElement("rest_freeze_amount")]
        public string RestFreezeAmount { get; set; }

        /// <summary>
        /// 商户的支付宝用户id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 冻结或者解冻金额
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 业务操作状态，Y表示成功；N或者其它值均表示失败
        /// </summary>
        [XmlElement("trans_status")]
        public string TransStatus { get; set; }

        /// <summary>
        /// 操作类型，FREEZE表示冻结操作；UNFREEZE表示解冻操作
        /// </summary>
        [XmlElement("trans_type")]
        public string TransType { get; set; }
    }
}
