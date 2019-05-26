using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBossProdSubmerchantModifyResponse.
    /// </summary>
    public class AlipayBossProdSubmerchantModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 受理商户在支付宝入驻后的识别号，商户入驻后由支付宝返回
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
