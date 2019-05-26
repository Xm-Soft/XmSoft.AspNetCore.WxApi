using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampTriggerResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampTriggerResponse : AliApiResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动流水id
        /// </summary>
        [XmlElement("camp_log_id")]
        public string CampLogId { get; set; }

        /// <summary>
        /// logonId的脱敏显示
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 拓展字段, 常用key有: prize_amount(奖品金额,单位为元); prize_type(奖品类型); mobile_send_flag(拉新活动发放凭证标识，标识为true且接口返回错误码CERTIFICATE_SEND_SUCCESS时，表示新用户发凭证成功，引导用户使用该手机号注册支付宝账号); errorMsg(错误信息描述); errorMsgType(错误信息类型，包括：CAMP_NOT_VALID--活动未生效，FREQ_OR_COUNT_LIMIT--频率或次数超限，RULE_NOT_PASS--规则未通过，NOT_WIN--未中奖); ruleErrorCode(规则验证不通过的错误码，值为AE0111709606 且返回的errorMsg为“00005000-规则中心规则不通过”时，表示用户已领取过奖品)
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 奖品唯一标识
        /// </summary>
        [XmlElement("prize_flag")]
        public string PrizeFlag { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 是否中奖结果状态，如果为true时返回的结果中的其他字段非空，否则返回的其他字段为空
        /// </summary>
        [XmlElement("trigger_result")]
        public bool TriggerResult { get; set; }
    }
}
