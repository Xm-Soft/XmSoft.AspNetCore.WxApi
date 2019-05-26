using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppCodetesttestResponse.
    /// </summary>
    public class AlipayOpenAppCodetesttestResponse : AliApiResponse
    {
        /// <summary>
        /// 测试测试测试
        /// </summary>
        [XmlElement("testtesttest")]
        public string Testtesttest { get; set; }
    }
}
