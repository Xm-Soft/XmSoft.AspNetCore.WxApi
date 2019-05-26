using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBusinesslicenseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrBusinesslicenseQueryModel : AliApiObject
    {
        /// <summary>
        /// 营业执照图片base64加密后内容
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
