using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenCreateResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 蚂蚁通行证id
        /// </summary>
        [XmlElement("ant_id")]
        public string AntId { get; set; }
    }
}
