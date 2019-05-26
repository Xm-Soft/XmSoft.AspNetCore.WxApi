using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ArticleParagraph Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleParagraph : AliApiObject
    {
        /// <summary>
        /// 图片列表
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("article_picture")]
        public List<ArticlePicture> Pictures { get; set; }

        /// <summary>
        /// 文章正文描述
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
