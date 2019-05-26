using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandAutomatApplyUploadResponse.
    /// </summary>
    public class AntMerchantExpandAutomatApplyUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝设备ID
        /// </summary>
        [XmlElement("alipay_terminal_id")]
        public string AlipayTerminalId { get; set; }
    }
}
