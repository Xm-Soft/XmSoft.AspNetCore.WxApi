using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MybankCreditLoantradeLoanpayAssetConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeLoanpayAssetConsultModel : AliApiObject
    {
        /// <summary>
        /// 支付宝签约商户ID，如PARTNER_ALIBABA_CN, PARTNER_TAOBAO_ORDER
        /// </summary>
        [XmlElement("alipay_partner_id")]
        public string AlipayPartnerId { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("apply_amt")]
        public MultiCurrencyMoneyVO ApplyAmt { get; set; }

        /// <summary>
        /// 具体咨询扩展，一笔订单对应数组中一个元素
        /// </summary>
        [XmlArray("order_info")]
        [XmlArrayItem("loan_pay_consult_order")]
        public List<LoanPayConsultOrder> OrderInfo { get; set; }

        /// <summary>
        /// 收单销售产品码
        /// </summary>
        [XmlElement("payment_sale_pd_code")]
        public string PaymentSalePdCode { get; set; }

        /// <summary>
        /// 交易平台类型，如b2b, nongzi
        /// </summary>
        [XmlElement("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 交易平台子类型，收单参数，如1688_hp
        /// </summary>
        [XmlElement("sub_platform_type")]
        public string SubPlatformType { get; set; }

        /// <summary>
        /// 用户信息 是
        /// </summary>
        [XmlElement("user")]
        public LoanPayUser User { get; set; }
    }
}
