using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsGoodsBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsGoodsBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 货品信息
        /// </summary>
        [XmlArray("goods")]
        [XmlArrayItem("goods_v_o")]
        public List<GoodsVO> Goods { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
