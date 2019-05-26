using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenOperationPartnerLoginCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationPartnerLoginCreateModel : AliApiObject
    {
        /// <summary>
        /// 三方合作服务商的员工支付宝UID，要求唯一。需要三方员工通过授权操作提供。
        /// </summary>
        [XmlElement("staff_user_id")]
        public string StaffUserId { get; set; }
    }
}
