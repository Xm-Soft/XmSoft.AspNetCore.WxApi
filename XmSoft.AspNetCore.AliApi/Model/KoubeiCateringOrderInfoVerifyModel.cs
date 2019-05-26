using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringOrderInfoVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoVerifyModel : AliApiObject
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户核销码中的核销数值串
        /// </summary>
        [XmlElement("verify_order_id")]
        public string VerifyOrderId { get; set; }
    }
}
