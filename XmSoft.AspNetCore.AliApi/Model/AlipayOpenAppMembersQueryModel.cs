using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppMembersQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMembersQueryModel : AliApiObject
    {
        /// <summary>
        /// 成员的角色类型，DEVELOPER-开发者，EXPERIENCER-体验者
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
