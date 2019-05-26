using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 漏洞信息
        /// </summary>
        [XmlElement("data")]
        public VulInfo Data { get; set; }
    }
}
