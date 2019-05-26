using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrIdcardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrIdcardQueryModel : AliApiObject
    {
        /// <summary>
        /// 身份证图片base64编码内容
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// face: 身份证正面  back: 身份证反面  缺省值是：face
        /// </summary>
        [XmlElement("side")]
        public string Side { get; set; }
    }
}
