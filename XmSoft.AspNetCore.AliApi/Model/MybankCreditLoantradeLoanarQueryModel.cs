using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MybankCreditLoantradeLoanarQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeLoanarQueryModel : AliApiObject
    {
        /// <summary>
        /// 客户的角色编号
        /// </summary>
        [XmlElement("iproleid")]
        public string Iproleid { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("loanarno")]
        public string Loanarno { get; set; }
    }
}
