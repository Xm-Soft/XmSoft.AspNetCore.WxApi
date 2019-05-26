using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiShopExternalDataSyncResponse.
    /// </summary>
    public class KoubeiShopExternalDataSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 流水结果描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 申请流水Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 流水处理成功  SUCESS(成功)  PROCESS(处理中)
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
