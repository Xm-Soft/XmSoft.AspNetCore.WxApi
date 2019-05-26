using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveBillInferenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveBillInferenceQueryModel : AliApiObject
    {
        /// <summary>
        /// 图片大小
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
