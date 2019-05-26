using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppAuthsubsAddResponse.
    /// </summary>
    public class AlipayOpenAppAuthsubsAddResponse : AliApiResponse
    {
        /// <summary>
        /// 授权结果唯一标识
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 表明订购失效时间
        /// </summary>
        [XmlElement("invalid_date")]
        public string InvalidDate { get; set; }
    }
}
