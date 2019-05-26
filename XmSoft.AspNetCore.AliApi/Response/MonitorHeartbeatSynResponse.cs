using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MonitorHeartbeatSynResponse.
    /// </summary>
    public class MonitorHeartbeatSynResponse : AliApiResponse
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
