using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMerchantActivityBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 活动所属场景，只支持单个场景，目前支持枚举类型：点餐场景：DISH、预点餐场景：PRE_DISH、菜单场景：MENU
        /// </summary>
        [XmlArray("biz_scenes")]
        [XmlArrayItem("string")]
        public List<string> BizScenes { get; set; }

        /// <summary>
        /// 外部请求号，控制幂等
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分页查询页码page_num必须大于1的整数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询每页项数page_size不能超过范围1~100的整数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店Id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
