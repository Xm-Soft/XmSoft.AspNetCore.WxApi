using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaMerchantOrderRentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderRentCancelModel : AliApiObject
    {
        /// <summary>
        /// 信用借还订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 信用借还的产品码:w1010100000000002858
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
