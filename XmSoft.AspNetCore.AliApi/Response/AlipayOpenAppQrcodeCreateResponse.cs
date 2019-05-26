using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenAppQrcodeCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 二维码图片链接地址
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
