using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingToolPointsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolPointsQueryModel : AliApiObject
    {
        /// <summary>
        /// 活动积分帐户
        /// </summary>
        [XmlElement("activity_account")]
        public string ActivityAccount { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
