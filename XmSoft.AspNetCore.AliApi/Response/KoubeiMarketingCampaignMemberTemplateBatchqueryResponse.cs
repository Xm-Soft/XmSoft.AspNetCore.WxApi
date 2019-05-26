using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMemberTemplateBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 会员模板模型
        /// </summary>
        [XmlArray("member_templates")]
        [XmlArrayItem("merchant_member_template_model")]
        public List<MerchantMemberTemplateModel> MemberTemplates { get; set; }
    }
}
