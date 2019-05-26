using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsCooperationProductQueryResponse.
    /// </summary>
    public class AlipayInsCooperationProductQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 保险产品
        /// </summary>
        [XmlElement("product")]
        public InsProduct Product { get; set; }
    }
}
