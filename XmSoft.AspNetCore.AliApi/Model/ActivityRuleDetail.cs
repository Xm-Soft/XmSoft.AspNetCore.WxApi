using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ActivityRuleDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityRuleDetail : AliApiObject
    {
        /// <summary>
        /// 活动规则中用户承诺消费的金额，当consume_type为CONSUME_AMOUNT时启用，单位为元
        /// </summary>
        [XmlElement("rule_amount")]
        public long RuleAmount { get; set; }

        /// <summary>
        /// 活动规则中用户满足承诺可享受的优惠，单位百分，值为1-100之间，如88折传88，7折传70
        /// </summary>
        [XmlElement("rule_discount")]
        public long RuleDiscount { get; set; }

        /// <summary>
        /// 承诺消费活动规则周期，单位为天。
        /// </summary>
        [XmlElement("rule_period")]
        public long RulePeriod { get; set; }

        /// <summary>
        /// 活动规则中用户承诺消费次数，当rule_type为CONSUME_TIMES时启用，单位为次。
        /// </summary>
        [XmlElement("rule_times")]
        public long RuleTimes { get; set; }
    }
}
