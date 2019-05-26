using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseGroupCreateResponse.
    /// </summary>
    public class AlipaySocialBaseGroupCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
