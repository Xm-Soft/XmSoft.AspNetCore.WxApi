using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozIdentificationUserWebInitializeResponse.
    /// </summary>
    public class ZolozIdentificationUserWebInitializeResponse : AliApiResponse
    {
        /// <summary>
        /// 扩展结果
        /// </summary>
        [XmlElement("extern_info")]
        public string ExternInfo { get; set; }

        /// <summary>
        /// 刷脸认证的唯一标识
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
