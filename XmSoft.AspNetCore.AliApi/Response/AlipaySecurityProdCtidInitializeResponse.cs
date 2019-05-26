using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdCtidInitializeResponse.
    /// </summary>
    public class AlipaySecurityProdCtidInitializeResponse : AliApiResponse
    {
        /// <summary>
        /// 随机数，用于生成authcode
        /// </summary>
        [XmlElement("random_data")]
        public string RandomData { get; set; }

        /// <summary>
        /// 公安一所返回的流水号
        /// </summary>
        [XmlElement("stream_number")]
        public string StreamNumber { get; set; }
    }
}
