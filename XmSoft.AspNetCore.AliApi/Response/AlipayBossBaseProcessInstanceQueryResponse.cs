using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceQueryResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 流程实例内容
        /// </summary>
        [XmlElement("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
