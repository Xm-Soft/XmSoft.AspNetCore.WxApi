using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionPromoteResponse.
    /// </summary>
    public class KoubeiAdvertCommissionMissionPromoteResponse : AliApiResponse
    {
        /// <summary>
        /// 广告详情
        /// </summary>
        [XmlElement("advert")]
        public KbAdvertAdvResponse Advert { get; set; }

        /// <summary>
        /// true:可以二级分佣配置  false:不可以
        /// </summary>
        [XmlElement("can_cascade_mission")]
        public string CanCascadeMission { get; set; }
    }
}
