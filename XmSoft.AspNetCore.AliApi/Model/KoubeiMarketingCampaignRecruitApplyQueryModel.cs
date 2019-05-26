using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitApplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignRecruitApplyQueryModel : AliApiObject
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 分页号
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小,最大值200
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
