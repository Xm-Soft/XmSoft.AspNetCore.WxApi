using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsDataAutodamageImageUploadResponse.
    /// </summary>
    public class AlipayInsDataAutodamageImageUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 图像文件在oss存储上的路径
        /// </summary>
        [XmlElement("image_path")]
        public string ImagePath { get; set; }
    }
}
