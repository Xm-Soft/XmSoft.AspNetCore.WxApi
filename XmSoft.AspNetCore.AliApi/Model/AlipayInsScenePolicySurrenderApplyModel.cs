using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsScenePolicySurrenderApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePolicySurrenderApplyModel : AliApiObject
    {
        /// <summary>
        /// 退保扩展参数 ;标准json格式
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 蚂蚁保险平台生成的保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
