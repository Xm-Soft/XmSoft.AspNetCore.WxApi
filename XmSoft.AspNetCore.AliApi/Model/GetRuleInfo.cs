using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// GetRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GetRuleInfo : AliApiObject
    {
        /// <summary>
        /// 截至时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 发放次数限制
        /// </summary>
        [XmlElement("get_count_limit")]
        public PeriodInfo GetCountLimit { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
