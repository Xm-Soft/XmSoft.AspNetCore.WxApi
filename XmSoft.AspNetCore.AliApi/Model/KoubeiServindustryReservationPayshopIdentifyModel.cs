using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiServindustryReservationPayshopIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryReservationPayshopIdentifyModel : AliApiObject
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
