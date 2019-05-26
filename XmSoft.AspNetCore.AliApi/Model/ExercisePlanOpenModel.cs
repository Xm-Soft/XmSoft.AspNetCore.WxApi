using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ExercisePlanOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class ExercisePlanOpenModel : AliApiObject
    {
        /// <summary>
        /// 运动计划类型。枚举：运动项目(ITEM),或课程(COURSE)
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 课程列表。当biz_type=COURSE时必填
        /// </summary>
        [XmlArray("course_list")]
        [XmlArrayItem("exercise_course_open_model")]
        public List<ExerciseCourseOpenModel> CourseList { get; set; }

        /// <summary>
        /// 一级健身项目列表。当biz_type=ITEM时必填
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("exercise_item_open_model")]
        public List<ExerciseItemOpenModel> ItemList { get; set; }

        /// <summary>
        /// 时间维度类型。枚举：DAY("日"),WEEK("周"),MONTH("月"),LIFE("终生")
        /// </summary>
        [XmlElement("time_dimension_type")]
        public string TimeDimensionType { get; set; }

        /// <summary>
        /// 维度所所对应的值。用英文逗号,分割。DAY时留空，WEEK时取值范围1-7，MONTH时取值范围1-31，LIFE时为yyyy-MM-dd格式的日期
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
