using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandItemStatusModifyResponse.
    /// </summary>
    public class AntMerchantExpandItemStatusModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
