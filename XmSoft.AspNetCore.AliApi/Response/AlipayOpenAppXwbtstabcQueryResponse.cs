using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppXwbtstabcQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbtstabcQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xwbbbdd")]
        public string Xwbbbdd { get; set; }
    }
}
