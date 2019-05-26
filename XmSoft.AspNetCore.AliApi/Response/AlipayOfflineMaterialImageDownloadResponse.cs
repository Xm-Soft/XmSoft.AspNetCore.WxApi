using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOfflineMaterialImageDownloadResponse.
    /// </summary>
    public class AlipayOfflineMaterialImageDownloadResponse : AliApiResponse
    {
        /// <summary>
        /// 图片地址列表，按入参id顺序返回，如果某个id转化失败，则用空字符占位
        /// </summary>
        [XmlArray("image_urls")]
        [XmlArrayItem("string")]
        public List<string> ImageUrls { get; set; }
    }
}
