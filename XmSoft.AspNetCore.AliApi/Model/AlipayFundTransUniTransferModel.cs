using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayFundTransUniTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransUniTransferModel : AliApiObject
    {
        /// <summary>
        /// 描述特定的业务场景，比如对党费缴纳场景需走党费专户
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账请求的扩展参数，具体请与支付宝工程师联系
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 转账的标题，用于在支付宝用户的账单里显示
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔转账请求，商户需保证该订单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 转账产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
