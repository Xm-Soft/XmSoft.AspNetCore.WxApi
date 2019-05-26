using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozIdentificationUserWebQueryResponse.
    /// </summary>
    public class ZolozIdentificationUserWebQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 扩展结果
        /// </summary>
        [XmlElement("extern_info")]
        public string ExternInfo { get; set; }
    }
}
