using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsScenePolicySurrenderApplyResponse.
    /// </summary>
    public class AlipayInsScenePolicySurrenderApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 蚂蚁保险平台生成的保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
