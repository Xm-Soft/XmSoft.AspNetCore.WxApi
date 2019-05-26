using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserTestResponse.
    /// </summary>
    public class AlipayUserTestResponse : AliApiResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("ret1")]
        public string Ret1 { get; set; }
    }
}
