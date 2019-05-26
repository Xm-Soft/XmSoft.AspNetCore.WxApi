using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayTradeBatchSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeBatchSettleModel : AliApiObject
    {
        /// <summary>
        /// 收单产品码，商家和支付宝签约的产品码
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 结算请求外部流水号，32个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 结算明细条款
        /// </summary>
        [XmlArray("settle_clauses")]
        [XmlArrayItem("settle_clause")]
        public List<SettleClause> SettleClauses { get; set; }
    }
}
