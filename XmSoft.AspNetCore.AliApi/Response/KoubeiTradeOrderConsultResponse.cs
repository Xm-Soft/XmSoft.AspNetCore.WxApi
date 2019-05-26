using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiTradeOrderConsultResponse.
    /// </summary>
    public class KoubeiTradeOrderConsultResponse : AliApiResponse
    {
        /// <summary>
        /// 用户实付金额
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [XmlArray("discount_detail")]
        [XmlArrayItem("discount_detail")]
        public List<DiscountDetail> DiscountDetail { get; set; }

        /// <summary>
        /// 储值卡信息
        /// </summary>
        [XmlElement("m_card_detail")]
        public MCardDetail MCardDetail { get; set; }

        /// <summary>
        /// 请求中的request_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
