using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataIsvShopQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataIsvShopQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 门店摘要信息列表
        /// </summary>
        [XmlArray("shop_summary_infos")]
        [XmlArrayItem("shop_summary_info")]
        public List<ShopSummaryInfo> ShopSummaryInfos { get; set; }
    }
}
