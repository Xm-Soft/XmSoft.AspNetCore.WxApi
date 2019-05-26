using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountQueryResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 广告投放出去的优惠信息
        /// </summary>
        [XmlElement("discount")]
        public DiscountInfo Discount { get; set; }
    }
}
