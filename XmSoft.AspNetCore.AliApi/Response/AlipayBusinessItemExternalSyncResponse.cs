using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBusinessItemExternalSyncResponse.
    /// </summary>
    public class AlipayBusinessItemExternalSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 入参中的request_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
