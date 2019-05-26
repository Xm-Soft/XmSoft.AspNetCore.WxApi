using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenMiniInneraccountPidQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInneraccountPidQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 虚拟PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
