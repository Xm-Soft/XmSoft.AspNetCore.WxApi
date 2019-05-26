using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsScenePolicyEndorseApplyResponse.
    /// </summary>
    public class AlipayInsScenePolicyEndorseApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 批单号
        /// </summary>
        [XmlElement("endorse_no")]
        public string EndorseNo { get; set; }

        /// <summary>
        /// 商户生成的批单请求单号【幂等字段】
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
