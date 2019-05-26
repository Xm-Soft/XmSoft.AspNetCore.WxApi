using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataAiserviceSmartpriceGetResponse.
    /// </summary>
    public class AlipayDataAiserviceSmartpriceGetResponse : AliApiResponse
    {
        /// <summary>
        /// 兼容V1.0。用户购买hellobike月卡的推荐价格，单位为分。
        /// </summary>
        [XmlElement("promo_price_cent")]
        public long PromoPriceCent { get; set; }

        /// <summary>
        /// 返回结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("hello_bike_price_result_item")]
        public List<HelloBikePriceResultItem> Result { get; set; }
    }
}
