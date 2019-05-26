using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateBindModel : AliApiObject
    {
        /// <summary>
        /// 将门店绑定到会员模板上，跟remove_shop_ids不可同时为空
        /// </summary>
        [XmlArray("add_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> AddShopIds { get; set; }

        /// <summary>
        /// 会员模板id
        /// </summary>
        [XmlElement("member_template_id")]
        public string MemberTemplateId { get; set; }

        /// <summary>
        /// 将门店与会员模板解绑，跟add_shop_ids不可同时为空
        /// </summary>
        [XmlArray("remove_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> RemoveShopIds { get; set; }

        /// <summary>
        /// 请求ID，由开发者生成并保证唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
