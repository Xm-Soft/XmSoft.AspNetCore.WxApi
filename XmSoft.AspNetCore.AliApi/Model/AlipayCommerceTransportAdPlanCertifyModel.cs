using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdPlanCertifyModel : AliApiObject
    {
        /// <summary>
        /// 广告系统用户ID
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }
    }
}
