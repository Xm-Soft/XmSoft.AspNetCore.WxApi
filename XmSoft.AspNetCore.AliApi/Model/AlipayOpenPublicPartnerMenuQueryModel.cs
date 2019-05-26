using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicPartnerMenuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPartnerMenuQueryModel : AliApiObject
    {
        /// <summary>
        /// 服务窗id
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
