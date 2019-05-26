using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsDataAutodamageRequestImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataAutodamageRequestImageInfo : AliApiObject
    {
        /// <summary>
        /// 图像文件名称
        /// </summary>
        [XmlElement("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 图像文件在存储上的路径
        /// </summary>
        [XmlElement("image_path")]
        public string ImagePath { get; set; }
    }
}
