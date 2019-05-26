using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemQueryModel : AliApiObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员类型，MER=商户
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }
    }
}
