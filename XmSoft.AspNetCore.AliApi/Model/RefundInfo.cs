using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// RefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundInfo : AliApiObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品单ID
        /// </summary>
        [XmlElement("item_order_no")]
        public string ItemOrderNo { get; set; }
    }
}
