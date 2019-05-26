using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FengdieSitesOwner Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesOwner : AliApiObject
    {
        /// <summary>
        /// 创建者的昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 云凤蝶空间成员所关联的第三方用户ID
        /// </summary>
        [XmlElement("origin_user_id")]
        public string OriginUserId { get; set; }
    }
}
