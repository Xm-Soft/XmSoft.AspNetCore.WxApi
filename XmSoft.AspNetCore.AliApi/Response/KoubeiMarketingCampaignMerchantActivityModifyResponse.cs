using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMerchantActivityModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 创建成功之后返回活动详情信息，包含活动activity_id和活动当前状态activity_status等信息。
        /// </summary>
        [XmlElement("activity_detail_info")]
        public MActivityDetailInfo ActivityDetailInfo { get; set; }
    }
}
