using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandAutomatApplyModifyResponse.
    /// </summary>
    public class AntMerchantExpandAutomatApplyModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝设备ID
        /// </summary>
        [XmlElement("alipay_terminal_id")]
        public string AlipayTerminalId { get; set; }
    }
}
