using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarDataExternalQueryResponse.
    /// </summary>
    public class AlipayEcoMycarDataExternalQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 30
        /// </summary>
        [XmlElement("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// outter_response
        /// </summary>
        [XmlElement("query_result")]
        public string QueryResult { get; set; }
    }
}
