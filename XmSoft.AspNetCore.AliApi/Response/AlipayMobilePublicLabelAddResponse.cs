using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelAddResponse.
    /// </summary>
    public class AlipayMobilePublicLabelAddResponse : AliApiResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 标签编码
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
