using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntfortuneMarketingCrowdWshopMatchResponse.
    /// </summary>
    public class AntfortuneMarketingCrowdWshopMatchResponse : AliApiResponse
    {
        /// <summary>
        /// 用户是否匹配人群，枚举值：true/false
        /// </summary>
        [XmlElement("match_result")]
        public bool MatchResult { get; set; }
    }
}
