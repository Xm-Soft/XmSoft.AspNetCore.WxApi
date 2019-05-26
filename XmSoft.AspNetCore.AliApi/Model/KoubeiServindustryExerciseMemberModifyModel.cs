using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseMemberModifyModel : AliApiObject
    {
        /// <summary>
        /// 会籍的到期时间 注：name与会籍的到期时间两个可选字段至少传一个
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 口碑的会籍id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 会籍名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
