using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbOrderShopModel Data Structure.
    /// </summary>
    [Serializable]
    public class KbOrderShopModel : AliApiObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 00007
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
