using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// Template Data Structure.
    /// </summary>
    [Serializable]
    public class Template : AliApiObject
    {
        /// <summary>
        /// 消息模板上下文，即模板中定义的参数及参数值
        /// </summary>
        [XmlElement("context")]
        public Context Context { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
