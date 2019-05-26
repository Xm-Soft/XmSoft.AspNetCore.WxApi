using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppMembersCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMembersCreateModel : AliApiObject
    {
        /// <summary>
        /// 支付宝登录账号ID
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 成员的角色类型，DEVELOPER-开发者，EXPERIENCER-体验者
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
