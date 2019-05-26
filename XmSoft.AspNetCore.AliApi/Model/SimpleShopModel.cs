using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SimpleShopModel Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleShopModel : AliApiObject
    {
        /// <summary>
        /// 商户门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
