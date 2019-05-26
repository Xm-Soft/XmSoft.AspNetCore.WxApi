using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrCarvinQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrCarvinQueryModel : AliApiObject
    {
        /// <summary>
        /// 汽车VIN 图片base64 encode内容
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
