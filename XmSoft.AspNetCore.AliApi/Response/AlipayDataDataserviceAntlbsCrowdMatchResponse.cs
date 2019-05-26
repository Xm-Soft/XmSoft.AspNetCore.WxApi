using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntlbsCrowdMatchResponse.
    /// </summary>
    public class AlipayDataDataserviceAntlbsCrowdMatchResponse : AliApiResponse
    {
        /// <summary>
        /// 匹配结果，入参中每个客群码都会返回是否匹配，即使该客群不存在
        /// </summary>
        [XmlArray("match_result")]
        [XmlArrayItem("promox_crowd_match_model")]
        public List<PromoxCrowdMatchModel> MatchResult { get; set; }
    }
}
