using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcWhitehatinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcWhitehatinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 白帽子信息
        /// </summary>
        [XmlElement("data")]
        public WhitehatInfo Data { get; set; }
    }
}
