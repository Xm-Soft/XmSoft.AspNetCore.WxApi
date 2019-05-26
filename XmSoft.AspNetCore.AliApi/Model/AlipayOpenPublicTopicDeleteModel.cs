using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicTopicDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicTopicDeleteModel : AliApiObject
    {
        /// <summary>
        /// 营销位id
        /// </summary>
        [XmlElement("topic_id")]
        public string TopicId { get; set; }
    }
}
