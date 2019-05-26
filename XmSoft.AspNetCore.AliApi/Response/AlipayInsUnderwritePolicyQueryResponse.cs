using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsUnderwritePolicyQueryResponse.
    /// </summary>
    public class AlipayInsUnderwritePolicyQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 保单
        /// </summary>
        [XmlElement("policy")]
        public InsPolicy Policy { get; set; }
    }
}
