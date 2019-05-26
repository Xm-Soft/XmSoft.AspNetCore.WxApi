using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOverseasTravelGkaCampaignApplyResponse.
    /// </summary>
    public class AlipayOverseasTravelGkaCampaignApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 奖品信息，发奖成功时返回
        /// </summary>
        [XmlElement("prize_info")]
        public PrizeInfo PrizeInfo { get; set; }

        /// <summary>
        /// 结果码，枚举值，目前支持TRIGGER_SUCCESS（发奖成功）、FREQ_OR_COUNT_LIMIT（频率或次数超限）、RULE_NOT_PASS（不满足活动规则）、CAMP_NOT_VALID（活动未生效）、NOT_WIN（未中奖）
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息，与result_code对应的结果信息提示，参见result_code
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
