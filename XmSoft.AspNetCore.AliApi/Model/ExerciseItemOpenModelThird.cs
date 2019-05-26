using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ExerciseItemOpenModelThird Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseItemOpenModelThird : AliApiObject
    {
        /// <summary>
        /// 健身项目简介
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 健身项目在外部(ISV)系统中的ID
        /// </summary>
        [XmlElement("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 必填项目类型码:由ISV保证唯一
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 计量信息列表
        /// </summary>
        [XmlElement("meter_list")]
        public MeterOpenModel MeterList { get; set; }

        /// <summary>
        /// 三级健身项目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父项目类型码
        /// </summary>
        [XmlElement("parent_item_code")]
        public string ParentItemCode { get; set; }
    }
}
