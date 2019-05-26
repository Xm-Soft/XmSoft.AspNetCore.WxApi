using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallShopitemsQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMallShopitemsQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("t_b_mini_shop_bo")]
        public List<TBMiniShopBo> ShopList { get; set; }
    }
}
