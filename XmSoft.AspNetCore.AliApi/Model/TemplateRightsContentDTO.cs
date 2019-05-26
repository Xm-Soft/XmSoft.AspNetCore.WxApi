using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// TemplateRightsContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateRightsContentDTO : AliApiObject
    {
        /// <summary>
        /// 权益内容详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 权益内容标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
