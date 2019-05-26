using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftModifyResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
