using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoRenthouseCommonImageUploadResponse.
    /// </summary>
    public class AlipayEcoRenthouseCommonImageUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 图片url地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
