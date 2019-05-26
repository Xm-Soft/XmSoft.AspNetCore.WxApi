using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PrizeLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeLiteInfo : AliApiObject
    {
        /// <summary>
        /// 外部奖品ID
        /// </summary>
        [XmlElement("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 奖品状态，可枚举，分别为“可用”(ENABLED)、“不可用”(DISABLED)、“不满足使用规则”(NOT_MATCH_USE_CONDITION)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
