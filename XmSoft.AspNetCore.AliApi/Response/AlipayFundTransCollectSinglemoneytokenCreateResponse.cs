using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayFundTransCollectSinglemoneytokenCreateResponse.
    /// </summary>
    public class AlipayFundTransCollectSinglemoneytokenCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 其他扩展属性
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 收钱二维码
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 吱口令文案
        /// </summary>
        [XmlElement("zhi_token")]
        public string ZhiToken { get; set; }
    }
}
