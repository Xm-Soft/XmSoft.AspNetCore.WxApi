using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMallInviteQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMallInviteQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 平台活动招商信息列表
        /// </summary>
        [XmlArray("activity_plan_info_list")]
        [XmlArrayItem("activity_plan_info")]
        public List<ActivityPlanInfo> ActivityPlanInfoList { get; set; }
    }
}
