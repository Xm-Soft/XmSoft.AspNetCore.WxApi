using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicleplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrVehicleplateQueryModel : AliApiObject
    {
        /// <summary>
        /// 车牌图片base64加密后内容
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
