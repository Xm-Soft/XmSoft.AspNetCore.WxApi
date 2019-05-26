using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandIsvShopCreateResponse.
    /// </summary>
    public class AntMerchantExpandIsvShopCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
