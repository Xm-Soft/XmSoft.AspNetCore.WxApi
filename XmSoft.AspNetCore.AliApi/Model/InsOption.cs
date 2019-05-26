using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// InsOption Data Structure.
    /// </summary>
    [Serializable]
    public class InsOption : AliApiObject
    {
        /// <summary>
        /// 保额key
        /// </summary>
        [XmlElement("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 保额value
        /// </summary>
        [XmlElement("coverage_text")]
        public string CoverageText { get; set; }
    }
}
