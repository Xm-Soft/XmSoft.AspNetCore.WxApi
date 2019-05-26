using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationApplyResponse.
    /// </summary>
    public class AlipayInsSceneApplicationApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 投保单号
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// 交易操作流水号;收银台付款需要
        /// </summary>
        [XmlElement("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号,必须保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号,同步创建保单的会有，异步创建保单的不返回
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 支付交易订单号,收银台付款需要
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
