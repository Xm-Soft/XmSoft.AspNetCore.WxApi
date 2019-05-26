using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsMarketingProductRecommendResponse.
    /// </summary>
    public class AlipayInsMarketingProductRecommendResponse : AliApiResponse
    {
        /// <summary>
        /// 产品列表
        /// </summary>
        [XmlArray("products")]
        [XmlArrayItem("recom_product")]
        public List<RecomProduct> Products { get; set; }

        /// <summary>
        /// 推荐流水号
        /// </summary>
        [XmlElement("recom_flow_no")]
        public string RecomFlowNo { get; set; }
    }
}
