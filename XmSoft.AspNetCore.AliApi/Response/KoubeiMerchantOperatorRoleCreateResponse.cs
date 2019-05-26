using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleCreateResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRoleCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 新增返回角色roleId,修改则返回修改的roleId.
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }
    }
}
