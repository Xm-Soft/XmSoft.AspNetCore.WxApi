using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertDeliveryDiscountQueryModel : AliApiObject
    {
        /// <summary>
        /// 优惠id，调用优惠查询接口时，需要提供“优惠id”
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
