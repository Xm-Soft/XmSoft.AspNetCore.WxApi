using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiTradeKbpaymentPayorderSyncResponse.
    /// </summary>
    public class KoubeiTradeKbpaymentPayorderSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
