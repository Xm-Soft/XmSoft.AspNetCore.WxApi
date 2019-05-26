using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCreateResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 创建的实例
        /// </summary>
        [XmlElement("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
