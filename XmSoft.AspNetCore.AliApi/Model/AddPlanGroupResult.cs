using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AddPlanGroupResult Data Structure.
    /// </summary>
    [Serializable]
    public class AddPlanGroupResult : AliApiObject
    {
        /// <summary>
        /// 新增计划下单元后，返回的单元ID列表
        /// </summary>
        [XmlArray("group_id_list")]
        [XmlArrayItem("number")]
        public List<long> GroupIdList { get; set; }

        /// <summary>
        /// 新增计划后计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }
    }
}
