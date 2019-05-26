using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AssuranceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssuranceInfo : AliApiObject
    {
        /// <summary>
        /// 服务保障的描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 服务保障的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
