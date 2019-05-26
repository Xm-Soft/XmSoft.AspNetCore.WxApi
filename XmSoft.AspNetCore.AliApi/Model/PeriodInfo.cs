using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PeriodInfo : AliApiObject
    {
        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 周期值
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
