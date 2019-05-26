using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserValidateResponse.
    /// </summary>
    public class AlipayUserValidateResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// true标识通过认证.false标识没有
        /// </summary>
        [XmlElement("certified")]
        public string Certified { get; set; }

        /// <summary>
        /// 隐藏的真实姓名，如 *三(张三)
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }
    }
}
