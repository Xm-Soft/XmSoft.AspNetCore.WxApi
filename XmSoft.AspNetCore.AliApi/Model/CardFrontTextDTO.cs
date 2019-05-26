using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// CardFrontTextDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardFrontTextDTO : AliApiObject
    {
        /// <summary>
        /// 文案标签
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 展示文案
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
