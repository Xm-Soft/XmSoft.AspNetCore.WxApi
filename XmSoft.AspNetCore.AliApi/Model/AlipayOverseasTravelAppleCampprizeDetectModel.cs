using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOverseasTravelAppleCampprizeDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelAppleCampprizeDetectModel : AliApiObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
