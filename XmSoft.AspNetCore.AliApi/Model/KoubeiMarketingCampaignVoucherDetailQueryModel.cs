using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignVoucherDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignVoucherDetailQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
