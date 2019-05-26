using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }
    }
}
