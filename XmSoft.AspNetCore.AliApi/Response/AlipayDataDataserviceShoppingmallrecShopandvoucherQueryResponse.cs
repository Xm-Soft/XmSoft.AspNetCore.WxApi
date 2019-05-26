using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceShoppingmallrecShopandvoucherQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceShoppingmallrecShopandvoucherQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 本次推荐的id, 开发者埋点需带入此参数
        /// </summary>
        [XmlElement("recommend_id")]
        public string RecommendId { get; set; }

        /// <summary>
        /// 本次请求的全局唯一标识, 支持英文字母和数字, 由开发者自行定义,和入参request_id一致
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 推荐商铺列表
        /// </summary>
        [XmlArray("shop_recommend_list")]
        [XmlArrayItem("shop_rec")]
        public List<ShopRec> ShopRecommendList { get; set; }

        /// <summary>
        /// 券推荐列表
        /// </summary>
        [XmlArray("voucher_recommend_list")]
        [XmlArrayItem("voucher_rec")]
        public List<VoucherRec> VoucherRecommendList { get; set; }
    }
}
