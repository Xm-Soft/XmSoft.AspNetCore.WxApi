using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// Picture Data Structure.
    /// </summary>
    [Serializable]
    public class Picture : AliApiObject
    {
        /// <summary>
        /// 调用alipay.offline.material.image.upload接口将图片上传到素材中心后，生成的ID
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
