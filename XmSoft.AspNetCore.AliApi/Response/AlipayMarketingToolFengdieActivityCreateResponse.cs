using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieActivityCreateResponse : AliApiResponse
    {
        /// <summary>
        /// H5应用的唯一id
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }
    }
}
