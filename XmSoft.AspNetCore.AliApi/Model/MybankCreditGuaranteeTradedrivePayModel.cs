using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MybankCreditGuaranteeTradedrivePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditGuaranteeTradedrivePayModel : AliApiObject
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 交易驱动金额，单位分
        /// </summary>
        [XmlElement("order_encash_amt")]
        public string OrderEncashAmt { get; set; }

        /// <summary>
        /// 交易驱动金额对应币种
        /// </summary>
        [XmlElement("order_encash_ccy")]
        public string OrderEncashCcy { get; set; }

        /// <summary>
        /// 还款业务编码。交易驱动还款时，根据AE的收款信息业务ID生成
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// AE卖家id
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 会员站点：AE:速卖通，ALIPAY:支付宝，MYBANK:网商银行，TAOBAO：淘宝，B2B_CN：中文站，B2B_EN：国际站
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }
    }
}
