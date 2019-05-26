using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// CommonDescInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonDescInfo : AliApiObject
    {
        /// <summary>
        /// 图片URL地址，最大不超过60K，必须使用https
        /// </summary>
        [XmlElement("img")]
        public string Img { get; set; }

        /// <summary>
        /// 文本描述
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
