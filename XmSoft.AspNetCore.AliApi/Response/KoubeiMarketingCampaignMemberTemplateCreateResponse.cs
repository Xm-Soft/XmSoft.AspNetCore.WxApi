using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMemberTemplateCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [XmlElement("member_template_id")]
        public string MemberTemplateId { get; set; }
    }
}
