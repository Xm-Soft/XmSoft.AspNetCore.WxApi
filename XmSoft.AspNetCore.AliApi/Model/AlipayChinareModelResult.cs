using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayChinareModelResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayChinareModelResult : AliApiObject
    {
        /// <summary>
        /// 体检记录id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 核保结果
        /// </summary>
        [XmlElement("rule_result")]
        public string RuleResult { get; set; }

        /// <summary>
        /// 交易流水记录id
        /// </summary>
        [XmlElement("trans_id")]
        public string TransId { get; set; }
    }
}
