using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaDataFeedbackurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaDataFeedbackurlQueryModel : AliApiObject
    {
        /// <summary>
        /// 在支付宝商户版注册支付宝账号id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
