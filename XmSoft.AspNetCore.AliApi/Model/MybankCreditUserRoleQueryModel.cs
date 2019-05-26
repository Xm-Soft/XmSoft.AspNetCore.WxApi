using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MybankCreditUserRoleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditUserRoleQueryModel : AliApiObject
    {
        /// <summary>
        /// 站点会员信息
        /// </summary>
        [XmlElement("member")]
        public Member Member { get; set; }
    }
}
