using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiServindustryExercisePlancourseSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExercisePlancourseSyncModel : AliApiObject
    {
        /// <summary>
        /// 数据版本号。linux时间戳，到毫秒级别。如果同步数据的版本号小于口碑服务器已有数据的版本号，则会被丢弃。
        /// </summary>
        [XmlElement("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 口碑用户健身通行证ID，和用户ID一一对应
        /// </summary>
        [XmlElement("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 健身计划列表
        /// </summary>
        [XmlArray("plan_list")]
        [XmlArrayItem("exercise_plan_open_model")]
        public List<ExercisePlanOpenModel> PlanList { get; set; }

        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
