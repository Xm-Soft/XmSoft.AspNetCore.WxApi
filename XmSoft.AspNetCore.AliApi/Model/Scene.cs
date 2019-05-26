using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// Scene Data Structure.
    /// </summary>
    [Serializable]
    public class Scene : AliApiObject
    {
        /// <summary>
        /// 场景Id，最长32位，英文字母、数字以及下划线，开发者自定义
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
