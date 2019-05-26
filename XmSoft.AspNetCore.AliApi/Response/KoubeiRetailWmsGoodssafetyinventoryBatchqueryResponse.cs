using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsGoodssafetyinventoryBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 货品安全库存列表
        /// </summary>
        [XmlArray("goods_safety_inventory_vo_list")]
        [XmlArrayItem("goods_safety_inventory_v_o")]
        public List<GoodsSafetyInventoryVO> GoodsSafetyInventoryVoList { get; set; }
    }
}
