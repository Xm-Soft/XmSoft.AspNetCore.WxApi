using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// EduAgeDemand Data Structure.
    /// </summary>
    [Serializable]
    public class EduAgeDemand : AliApiObject
    {
        /// <summary>
        /// 结束年龄
        /// </summary>
        [XmlElement("age_end")]
        public string AgeEnd { get; set; }

        /// <summary>
        /// 开始年龄
        /// </summary>
        [XmlElement("age_start")]
        public string AgeStart { get; set; }
    }
}
