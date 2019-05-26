using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBossBaseProcessTaskProcessResponse.
    /// </summary>
    public class AlipayBossBaseProcessTaskProcessResponse : AliApiResponse
    {
        /// <summary>
        /// 流程实例数据
        /// </summary>
        [XmlElement("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
