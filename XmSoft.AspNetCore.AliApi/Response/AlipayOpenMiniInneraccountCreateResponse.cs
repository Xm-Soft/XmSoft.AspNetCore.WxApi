using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenMiniInneraccountCreateResponse.
    /// </summary>
    public class AlipayOpenMiniInneraccountCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 虚拟PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
