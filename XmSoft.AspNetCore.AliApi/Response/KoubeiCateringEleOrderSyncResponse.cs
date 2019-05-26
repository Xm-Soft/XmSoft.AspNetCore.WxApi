using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringEleOrderSyncResponse.
    /// </summary>
    public class KoubeiCateringEleOrderSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 原始的订单id编号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
