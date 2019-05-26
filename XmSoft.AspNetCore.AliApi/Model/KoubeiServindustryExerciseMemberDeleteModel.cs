using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseMemberDeleteModel : AliApiObject
    {
        /// <summary>
        /// 口碑的会籍ID
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外部请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
