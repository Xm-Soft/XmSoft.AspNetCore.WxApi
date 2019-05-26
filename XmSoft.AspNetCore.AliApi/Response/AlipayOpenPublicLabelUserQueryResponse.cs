using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicLabelUserQueryResponse.
    /// </summary>
    public class AlipayOpenPublicLabelUserQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户标签id列表，以英文逗号分隔
        /// </summary>
        [XmlElement("label_ids")]
        public string LabelIds { get; set; }
    }
}
