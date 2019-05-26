using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarDataExternalSendResponse.
    /// </summary>
    public class AlipayEcoMycarDataExternalSendResponse : AliApiResponse
    {
        /// <summary>
        /// 20
        /// </summary>
        [XmlElement("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// outter_response
        /// </summary>
        [XmlElement("process_result")]
        public string ProcessResult { get; set; }
    }
}
