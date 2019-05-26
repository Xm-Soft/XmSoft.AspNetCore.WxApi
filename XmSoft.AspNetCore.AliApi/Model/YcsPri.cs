using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// YcsPri Data Structure.
    /// </summary>
    [Serializable]
    public class YcsPri : AliApiObject
    {
        /// <summary>
        /// aaa
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 支持输入标准html超链接：<a href="url" target="_blank">Link text</a>例如：<a href="https://open.alipay.com" target="_blank">蚂蚁开放平台</a>
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }
    }
}
