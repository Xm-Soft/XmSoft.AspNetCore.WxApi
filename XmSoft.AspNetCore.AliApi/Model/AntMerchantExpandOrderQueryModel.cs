using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandOrderQueryModel : AliApiObject
    {
        /// <summary>
        /// 通过ant.merchant.expand.indirect.zmsub.create等接口进件时返回的order_id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
