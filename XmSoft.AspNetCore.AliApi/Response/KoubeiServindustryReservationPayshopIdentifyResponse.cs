using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiServindustryReservationPayshopIdentifyResponse.
    /// </summary>
    public class KoubeiServindustryReservationPayshopIdentifyResponse : AliApiResponse
    {
        /// <summary>
        /// 是否付费店铺
        /// </summary>
        [XmlElement("pay_shop")]
        public bool PayShop { get; set; }
    }
}
