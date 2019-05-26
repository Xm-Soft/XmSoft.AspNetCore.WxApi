using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYiyiyiwuQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("chucan")]
        public string Chucan { get; set; }
    }
}
