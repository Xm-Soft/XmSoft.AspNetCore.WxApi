using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MemberBenefitModel Data Structure.
    /// </summary>
    [Serializable]
    public class MemberBenefitModel : AliApiObject
    {
        /// <summary>
        /// 权益描述信息
        /// </summary>
        [XmlArray("benefit_desc")]
        [XmlArrayItem("string")]
        public List<string> BenefitDesc { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
