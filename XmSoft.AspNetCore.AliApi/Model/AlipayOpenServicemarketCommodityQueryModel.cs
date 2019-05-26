using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommodityQueryModel : AliApiObject
    {
        /// <summary>
        /// 服务插件ID
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 服务创建者ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
