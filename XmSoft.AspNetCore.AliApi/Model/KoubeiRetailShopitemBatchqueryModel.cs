using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailShopitemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailShopitemBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 查询店铺商品查询入参
        /// </summary>
        [XmlArray("shop_items")]
        [XmlArrayItem("request_ext_shop_item_query")]
        public List<RequestExtShopItemQuery> ShopItems { get; set; }
    }
}
