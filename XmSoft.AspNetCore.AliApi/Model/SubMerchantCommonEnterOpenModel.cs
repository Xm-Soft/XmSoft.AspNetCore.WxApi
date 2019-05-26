using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SubMerchantCommonEnterOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class SubMerchantCommonEnterOpenModel : AliApiObject
    {
        /// <summary>
        /// 扩展字段，为json字符串格式；入驻支付即开票的产品，需要传入用户白名单的时候，由此字段传入
        /// </summary>
        [XmlElement("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 商户门店入驻的产品码,QRCODE_MERCHANT_OPEN:企业自建-扫码开票，INVOICE_RETURN:企业自建-发票回传，INVOICE_EXPENSE:发票报销，PAYMENT_OPEN:支付即开票。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户门店所属的服务方简称。
        /// </summary>
        [XmlElement("s_short_name")]
        public string SShortName { get; set; }
    }
}
