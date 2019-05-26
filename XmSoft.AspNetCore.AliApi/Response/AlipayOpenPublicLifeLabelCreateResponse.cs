using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeLabelCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [XmlElement("label_id")]
        public string LabelId { get; set; }
    }
}
