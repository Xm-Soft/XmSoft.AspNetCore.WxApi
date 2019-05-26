using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicLabelUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelUserCreateModel : AliApiObject
    {
        /// <summary>
        /// 要绑定的标签Id
        /// </summary>
        [XmlElement("label_id")]
        public long LabelId { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头长度为16位的字符串
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
