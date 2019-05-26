using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingEncodeShortlinkCreateResponse.
    /// </summary>
    public class AlipayMarketingEncodeShortlinkCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 将长连接改写成短连接，改写成功后的短连接地址
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
