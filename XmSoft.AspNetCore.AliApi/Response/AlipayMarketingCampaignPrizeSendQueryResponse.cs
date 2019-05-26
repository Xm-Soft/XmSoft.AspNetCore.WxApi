using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeSendQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeSendQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 中奖信息列表
        /// </summary>
        [XmlArray("prize_detail_list")]
        [XmlArrayItem("prize_detail")]
        public List<PrizeDetail> PrizeDetailList { get; set; }
    }
}
