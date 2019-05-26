using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBankcardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrBankcardQueryModel : AliApiObject
    {
        /// <summary>
        /// 图片base64后内容，大小控制在1M以内
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
