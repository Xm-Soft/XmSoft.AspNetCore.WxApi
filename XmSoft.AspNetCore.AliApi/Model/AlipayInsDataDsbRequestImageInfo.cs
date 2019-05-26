using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsDataDsbRequestImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbRequestImageInfo : AliApiObject
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
