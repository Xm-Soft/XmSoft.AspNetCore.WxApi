using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehiclelicenseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrVehiclelicenseQueryModel : AliApiObject
    {
        /// <summary>
        /// 行驶证图片base64加密后内容，大小限制在1.5M
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
