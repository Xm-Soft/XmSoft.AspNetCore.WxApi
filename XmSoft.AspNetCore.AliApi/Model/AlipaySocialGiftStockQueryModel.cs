using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySocialGiftStockQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialGiftStockQueryModel : AliApiObject
    {
        /// <summary>
        /// 券码列表，商户体系内可兑换使用的券码。如果该值为空的话，则改接口会检查总库存和剩余可用库存。不为空则检查该列表中对应的卡码是否正确导入。
        /// </summary>
        [XmlArray("entity_list")]
        [XmlArrayItem("string")]
        public List<string> EntityList { get; set; }

        /// <summary>
        /// 商户再送礼平台分配的商户id，用于标识具体的调用业务方，需要先在送礼平台进行业务类型的分配之后才看使用。
        /// </summary>
        [XmlElement("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 对应送礼平台skuId，库存导入必须指定唯一的一个SKUID，该id需要送礼平台方先创建相应产品后，在通知使用方
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
