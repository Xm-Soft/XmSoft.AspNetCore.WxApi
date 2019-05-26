using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MEquityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MEquityInfo : AliApiObject
    {
        /// <summary>
        /// 权益的展示信息，仅当equity_type=VOUCHER时，该值必填，其他类型无需设置
        /// </summary>
        [XmlElement("equity_display_info")]
        public MEquityDisplayInfo EquityDisplayInfo { get; set; }

        /// <summary>
        /// 权益类型，枚举取值：券类型：VOUCHER、立减实时优惠类型：DISCOUNT
        /// </summary>
        [XmlElement("equity_type")]
        public string EquityType { get; set; }

        /// <summary>
        /// 使用规则
        /// </summary>
        [XmlElement("equity_use_rule")]
        public MEquityUseRule EquityUseRule { get; set; }

        /// <summary>
        /// 权益的有效期信息，仅当equity_type=VOUCHER时，该值必填，其他类型无需设置
        /// </summary>
        [XmlElement("equity_valid_info")]
        public MEquityValidInfo EquityValidInfo { get; set; }

        /// <summary>
        /// 权益的价值信息
        /// </summary>
        [XmlElement("equity_worth_info")]
        public MEquityWorthInfo EquityWorthInfo { get; set; }
    }
}
