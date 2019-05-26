using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MybankCreditLoantradeRepayBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeRepayBudgetQueryModel : AliApiObject
    {
        /// <summary>
        /// 申请还款金额，如果budget_type为TOTAL_AMT，则填写还款总金额，如果为PRIN_AMT则填写还款本金
        /// </summary>
        [XmlElement("apply_repay_prin")]
        public string ApplyRepayPrin { get; set; }

        /// <summary>
        /// TOTAL_AMT：总额还款，PRIN_AMT：本金还款，如果为空，默认为本金还款
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 可为空，默认需要判断是否可还款，false为不需要判断是否可还款，其他为需要判断是否可还款
        /// </summary>
        [XmlElement("can_repay_flag")]
        public bool CanRepayFlag { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 银行参与者id，是在网商银行创建会员后生成的id，网商银行会员的唯一标识
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 银行参与者角色id，是在网商银行创建会员后生成的角色id，网商银行会员角色的唯一标识
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 贷款合约编号
        /// </summary>
        [XmlElement("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
