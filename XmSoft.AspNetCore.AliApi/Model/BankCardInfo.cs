using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// BankCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankCardInfo : AliApiObject
    {
        /// <summary>
        /// 银行开户行名称。填写支行名称。
        /// </summary>
        [XmlElement("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 银行卡持卡人姓名
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }
    }
}
