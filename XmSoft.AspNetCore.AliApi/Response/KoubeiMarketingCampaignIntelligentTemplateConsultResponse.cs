using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentTemplateConsultResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentTemplateConsultResponse : AliApiResponse
    {
        /// <summary>
        /// 营销模板的编号  GENERAL_NORMAL：全场普通；  ITEM_NORMAL：单品普通;  CROWD_NORMAL: 千人千券普通；
        /// </summary>
        [XmlArray("template_codes")]
        [XmlArrayItem("string")]
        public List<string> TemplateCodes { get; set; }
    }
}
