using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCrowdQueryResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCrowdQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 分组圈出的人群数量
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }
    }
}
