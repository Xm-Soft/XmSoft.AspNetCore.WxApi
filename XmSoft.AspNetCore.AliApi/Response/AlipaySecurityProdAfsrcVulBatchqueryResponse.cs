using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 漏洞信息列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("vul_list")]
        public List<VulList> Data { get; set; }
    }
}
