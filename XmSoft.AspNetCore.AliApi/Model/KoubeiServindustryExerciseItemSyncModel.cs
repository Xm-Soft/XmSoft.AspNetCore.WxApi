using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiServindustryExerciseItemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseItemSyncModel : AliApiObject
    {
        /// <summary>
        /// linux时间戳
        /// </summary>
        [XmlElement("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 健身项目列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("exercise_item")]
        public List<ExerciseItem> ItemList { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
