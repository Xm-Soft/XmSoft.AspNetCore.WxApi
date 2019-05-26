using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdPlanCreateModel : AliApiObject
    {
        /// <summary>
        /// 复杂类型，参见AdPlan定义
        /// </summary>
        [XmlElement("ad_plan")]
        public AdPlan AdPlan { get; set; }
    }
}
