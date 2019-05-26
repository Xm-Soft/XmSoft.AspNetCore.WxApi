using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateOnlineModel : AliApiObject
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [XmlElement("member_template_id")]
        public string MemberTemplateId { get; set; }

        /// <summary>
        /// 请求ID，由开发者生成并保证唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
