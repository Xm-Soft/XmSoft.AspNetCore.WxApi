using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoBasicRouterSendResponse.
    /// </summary>
    public class AlipayEcoBasicRouterSendResponse : AliApiResponse
    {
        /// <summary>
        /// 路由返回的数据
        /// </summary>
        [XmlElement("res")]
        public string Res { get; set; }
    }
}
