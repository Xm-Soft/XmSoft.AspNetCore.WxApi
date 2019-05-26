using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrImageclassifyQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrImageclassifyQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 图像分类类型
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }
    }
}
