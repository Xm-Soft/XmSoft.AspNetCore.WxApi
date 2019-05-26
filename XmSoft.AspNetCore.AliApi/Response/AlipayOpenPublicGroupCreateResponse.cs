using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCreateResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
