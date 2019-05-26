using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingDataRetailDmQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataRetailDmQueryModel : AliApiObject
    {
        /// <summary>
        /// 内容ID，调用koubei.marketing.campaign.retail.dm.create创建内容时返回的内容ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
