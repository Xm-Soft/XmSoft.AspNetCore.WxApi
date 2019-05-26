using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdCreativeOfflineModel : AliApiObject
    {
        /// <summary>
        /// 广告主id  + 下线创意时，需要校验该创意是否属于该用户
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 创意id + 根据创意id操作对应的创意下线
        /// </summary>
        [XmlElement("creative_id")]
        public long CreativeId { get; set; }
    }
}
