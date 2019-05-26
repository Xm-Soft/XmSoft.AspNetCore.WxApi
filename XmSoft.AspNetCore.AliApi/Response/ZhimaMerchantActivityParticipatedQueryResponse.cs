using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaMerchantActivityParticipatedQueryResponse.
    /// </summary>
    public class ZhimaMerchantActivityParticipatedQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户参加活动模型列表
        /// </summary>
        [XmlArray("activity_participation_list")]
        [XmlArrayItem("activity_participation")]
        public List<ActivityParticipation> ActivityParticipationList { get; set; }
    }
}
