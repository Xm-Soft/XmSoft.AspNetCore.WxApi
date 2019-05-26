using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBusinessItemInventoryExternalSyncResponse.
    /// </summary>
    public class AlipayBusinessItemInventoryExternalSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝商品id列表
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 入参中的request_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
