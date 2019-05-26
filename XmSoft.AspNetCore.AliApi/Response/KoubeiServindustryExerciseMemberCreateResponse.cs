using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberCreateResponse.
    /// </summary>
    public class KoubeiServindustryExerciseMemberCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑用户健身唯一ID，和支付宝userId一一对应
        /// </summary>
        [XmlElement("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 口碑的会籍ID
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }
    }
}
