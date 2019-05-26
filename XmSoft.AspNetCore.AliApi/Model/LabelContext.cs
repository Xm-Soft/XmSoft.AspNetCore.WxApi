using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// LabelContext Data Structure.
    /// </summary>
    [Serializable]
    public class LabelContext : AliApiObject
    {
        /// <summary>
        /// 标签组发圈人的单个过滤器信息
        /// </summary>
        [XmlElement("a")]
        public LabelFilter A { get; set; }
    }
}
