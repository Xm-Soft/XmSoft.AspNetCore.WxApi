using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicTopicCreateResponse.
    /// </summary>
    public class AlipayOpenPublicTopicCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 营销位id
        /// </summary>
        [XmlElement("topic_id")]
        public string TopicId { get; set; }
    }
}
