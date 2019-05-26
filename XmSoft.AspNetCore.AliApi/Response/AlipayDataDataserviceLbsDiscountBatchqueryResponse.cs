using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceLbsDiscountBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceLbsDiscountBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 广告投放出去的商品信息
        /// </summary>
        [XmlArray("discounts")]
        [XmlArrayItem("antlbs_k_b_discount_info")]
        public List<AntlbsKBDiscountInfo> Discounts { get; set; }
    }
}
