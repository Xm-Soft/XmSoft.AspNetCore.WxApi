using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseSceneContentQueryResponse.
    /// </summary>
    public class AlipaySocialBaseSceneContentQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 内容中台场景页文章信息
        /// </summary>
        [XmlArray("scene_content")]
        [XmlArrayItem("scene_content")]
        public List<SceneContent> SceneContent { get; set; }

        /// <summary>
        /// 场景详情信息
        /// </summary>
        [XmlElement("scene_detail")]
        public SceneDetail SceneDetail { get; set; }

        /// <summary>
        /// 更多文章跳转链接
        /// </summary>
        [XmlElement("scheme")]
        public string Scheme { get; set; }
    }
}
