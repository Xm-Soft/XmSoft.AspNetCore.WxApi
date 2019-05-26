using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountSendResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountSendResponse : AliApiResponse
    {
        /// <summary>
        /// 权益详细信息：  partnerId：商户ID（用于打开手机钱包券详情）
        /// </summary>
        [XmlElement("benefit_detail")]
        public string BenefitDetail { get; set; }

        /// <summary>
        /// 广告id对应的权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }
    }
}
