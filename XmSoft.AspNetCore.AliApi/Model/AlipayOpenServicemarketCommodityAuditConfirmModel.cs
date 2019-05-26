using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityAuditConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommodityAuditConfirmModel : AliApiObject
    {
        /// <summary>
        /// 服务插件ID
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
