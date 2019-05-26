using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbadvertSmartPromoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbadvertSmartPromoResponse : AliApiObject
    {
        /// <summary>
        /// 智能营销分组ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 智能营销方案ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
