using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAccountQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝账号userid，2088开头长度为16位的字符串
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
