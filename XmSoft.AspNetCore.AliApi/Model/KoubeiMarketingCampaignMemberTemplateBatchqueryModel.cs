using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [XmlArray("member_template_ids")]
        [XmlArrayItem("string")]
        public List<string> MemberTemplateIds { get; set; }
    }
}
