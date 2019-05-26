using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankMarketingCampaignPrizeListConsultResponse.
    /// </summary>
    public class MybankMarketingCampaignPrizeListConsultResponse : AliApiResponse
    {
        /// <summary>
        /// 可用的奖品列表
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("prize_model")]
        public List<PrizeModel> PrizeList { get; set; }
    }
}
