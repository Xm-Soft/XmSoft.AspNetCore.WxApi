using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ExerciseDailySummaryOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseDailySummaryOpenModel : AliApiObject
    {
        /// <summary>
        /// 时长：单位秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 目标类型:CARDIO，MUSCLE，FLEXIBILITY
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
