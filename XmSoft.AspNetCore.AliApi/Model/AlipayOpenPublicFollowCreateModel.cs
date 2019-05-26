using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicFollowCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicFollowCreateModel : AliApiObject
    {
        /// <summary>
        /// 来源，目前只有"tmall"
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
