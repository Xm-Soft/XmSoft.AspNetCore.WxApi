using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PosStallModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosStallModel : AliApiObject
    {
        /// <summary>
        /// 菜品下档口的排序号
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 档口ID
        /// </summary>
        [XmlElement("stall_id")]
        public string StallId { get; set; }

        /// <summary>
        /// 档口名字
        /// </summary>
        [XmlElement("stall_name")]
        public string StallName { get; set; }
    }
}
