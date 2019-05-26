using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaMerchantActivityParticipationQueryResponse.
    /// </summary>
    public class ZhimaMerchantActivityParticipationQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户参加活动模型
        /// </summary>
        [XmlElement("activity_participation")]
        public ActivityParticipation ActivityParticipation { get; set; }
    }
}
