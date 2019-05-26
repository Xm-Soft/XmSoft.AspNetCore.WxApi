using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// NewsfeedMediaVideoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaVideoInfo : AliApiObject
    {
        /// <summary>
        /// 高度
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 视频缩略图的ID（支持djangoId）
        /// </summary>
        [XmlElement("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 视频的id（支持djangoId）
        /// </summary>
        [XmlElement("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
