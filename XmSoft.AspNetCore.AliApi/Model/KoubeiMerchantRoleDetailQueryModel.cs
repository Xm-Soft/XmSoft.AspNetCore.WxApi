using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMerchantRoleDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantRoleDetailQueryModel : AliApiObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }
    }
}
