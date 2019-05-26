using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanGetResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanGetResponse : AliApiResponse
    {
        /// <summary>
        /// 计划详情
        /// </summary>
        [XmlElement("plan_result")]
        public AdPlan PlanResult { get; set; }
    }
}
