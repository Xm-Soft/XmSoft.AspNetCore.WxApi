using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayTrustUserScoreGetResponse.
    /// </summary>
    public class AlipayTrustUserScoreGetResponse : AliApiResponse
    {
        /// <summary>
        /// 芝麻信用通过模型计算出的该用户的芝麻信用评分
        /// </summary>
        [XmlElement("ali_trust_score")]
        public AliTrustScore AliTrustScore { get; set; }
    }
}
