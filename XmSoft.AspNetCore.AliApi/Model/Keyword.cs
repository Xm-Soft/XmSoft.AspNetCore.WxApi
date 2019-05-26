using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// Keyword Data Structure.
    /// </summary>
    [Serializable]
    public class Keyword : AliApiObject
    {
        /// <summary>
        /// 当前文字颜色
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 模板中占位符的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
