using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicLabelUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelUserQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝用户的userid，2088开头长度为16位的字符串
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
