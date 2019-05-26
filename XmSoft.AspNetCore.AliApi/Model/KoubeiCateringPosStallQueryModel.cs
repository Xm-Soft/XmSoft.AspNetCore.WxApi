using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosStallQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosStallQueryModel : AliApiObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
