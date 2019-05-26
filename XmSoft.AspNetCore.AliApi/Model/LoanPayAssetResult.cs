using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// LoanPayAssetResult Data Structure.
    /// </summary>
    [Serializable]
    public class LoanPayAssetResult : AliApiObject
    {
        /// <summary>
        /// 资金账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 可用额度
        /// </summary>
        [XmlElement("available_amount")]
        public MultiCurrencyMoneyVO AvailableAmount { get; set; }

        /// <summary>
        /// true为可用，false为不可用
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 提示文案，JSON大字段
        /// </summary>
        [XmlElement("hint_texts")]
        public string HintTexts { get; set; }

        /// <summary>
        /// 分期方案列表
        /// </summary>
        [XmlArray("installments")]
        [XmlArrayItem("loan_pay_installment")]
        public List<LoanPayInstallment> Installments { get; set; }

        /// <summary>
        /// 不可用信息
        /// </summary>
        [XmlElement("refuse_msg")]
        public Refuse RefuseMsg { get; set; }

        /// <summary>
        /// 方案id
        /// </summary>
        [XmlElement("scheme_id")]
        public string SchemeId { get; set; }
    }
}
