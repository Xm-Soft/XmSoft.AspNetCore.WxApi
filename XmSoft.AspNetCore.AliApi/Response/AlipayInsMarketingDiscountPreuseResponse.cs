using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsMarketingDiscountPreuseResponse.
    /// </summary>
    public class AlipayInsMarketingDiscountPreuseResponse : AliApiResponse
    {
        /// <summary>
        /// 预核销活动列表
        /// </summary>
        [XmlArray("pre_use_campaigns")]
        [XmlArrayItem("ins_mkt_pre_use_campaign_d_t_o")]
        public List<InsMktPreUseCampaignDTO> PreUseCampaigns { get; set; }

        /// <summary>
        /// 预核销权益列表
        /// </summary>
        [XmlArray("pre_use_coupons")]
        [XmlArrayItem("ins_mkt_pre_use_coupon_d_t_o")]
        public List<InsMktPreUseCouponDTO> PreUseCoupons { get; set; }
    }
}
