using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCardOpenApplyResponse.
    /// </summary>
    public class AlipayMarketingCardOpenApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 商户卡信息（包括支付宝分配的业务卡号）
        /// </summary>
        [XmlElement("card_info")]
        public MerchantCard CardInfo { get; set; }
    }
}
