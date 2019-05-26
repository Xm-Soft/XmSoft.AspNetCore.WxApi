using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringOrderInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoQueryModel : AliApiObject
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
