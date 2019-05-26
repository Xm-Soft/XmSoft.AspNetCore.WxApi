using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// StaffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StaffInfo : AliApiObject
    {
        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
