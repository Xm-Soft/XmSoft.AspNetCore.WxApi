using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingDataIsvShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataIsvShopQueryModel : AliApiObject
    {
        /// <summary>
        /// 门店ID列表（单次最多查询100个门店）
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
