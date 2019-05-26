using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhubUidTelPair Data Structure.
    /// </summary>
    [Serializable]
    public class ZhubUidTelPair : AliApiObject
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
