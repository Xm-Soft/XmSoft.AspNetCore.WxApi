using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsUnderwriteMutualPolicyBatchqueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteMutualPolicyBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 宝贝计划ID
        /// </summary>
        [XmlElement("plan_no")]
        public string PlanNo { get; set; }

        /// <summary>
        /// 保单ID列表,json格式
        /// </summary>
        [XmlArray("policy_nos")]
        [XmlArrayItem("string")]
        public List<string> PolicyNos { get; set; }
    }
}
