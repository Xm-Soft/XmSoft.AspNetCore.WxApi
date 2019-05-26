using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// NoticeTemplateArgs Data Structure.
    /// </summary>
    [Serializable]
    public class NoticeTemplateArgs : AliApiObject
    {
        /// <summary>
        /// 课程开始时间
        /// </summary>
        [XmlElement("course_start_time")]
        public string CourseStartTime { get; set; }
    }
}
