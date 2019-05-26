using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAfsrcVulQueryModel : AliApiObject
    {
        /// <summary>
        /// 漏洞id
        /// </summary>
        [XmlElement("vul_id")]
        public long VulId { get; set; }
    }
}
