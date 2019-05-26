using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// RiskProfileDto Data Structure.
    /// </summary>
    [Serializable]
    public class RiskProfileDto : AliApiObject
    {
        /// <summary>
        /// risk profile名称和入参对应
        /// </summary>
        [XmlElement("risk_profile")]
        public string RiskProfile { get; set; }

        /// <summary>
        /// risk profile对应主体的分值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
