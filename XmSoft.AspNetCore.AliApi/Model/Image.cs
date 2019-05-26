using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// Image Data Structure.
    /// </summary>
    [Serializable]
    public class Image : AliApiObject
    {
        /// <summary>
        /// 图片url，请先调用alipay.offline.material.image.upload 图片上传接口获得图片url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
