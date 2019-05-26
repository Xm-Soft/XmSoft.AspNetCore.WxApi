using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayToolsFileUploadResponse.
    /// </summary>
    public class AlipayToolsFileUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
