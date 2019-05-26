using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPaiProxyRedirectResponse.
    /// </summary>
    public class AlipayPaiProxyRedirectResponse : AliApiResponse
    {
        /// <summary>
        /// 测试返回数据，页面级接口此项没用
        /// </summary>
        [XmlElement("test_res")]
        public string TestRes { get; set; }
    }
}
