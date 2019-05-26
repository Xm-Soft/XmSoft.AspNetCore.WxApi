using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosStallDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosStallDeleteModel : AliApiObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 档口id
        /// </summary>
        [XmlElement("stall_id")]
        public string StallId { get; set; }
    }
}
