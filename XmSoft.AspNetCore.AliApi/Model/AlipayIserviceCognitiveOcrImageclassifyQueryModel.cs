using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrImageclassifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrImageclassifyQueryModel : AliApiObject
    {
        /// <summary>
        /// 图片base64加密后的内容，大小控制在1.5M
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
