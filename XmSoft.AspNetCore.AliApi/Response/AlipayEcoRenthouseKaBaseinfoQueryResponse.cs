using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoQueryResponse.
    /// </summary>
    public class AlipayEcoRenthouseKaBaseinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 返回kaCode唯一标识
        /// </summary>
        [XmlElement("ka_code")]
        public string KaCode { get; set; }

        /// <summary>
        /// ka名称
        /// </summary>
        [XmlElement("ka_name")]
        public string KaName { get; set; }

        /// <summary>
        /// 是否生效 1:生效 0:没有生效
        /// </summary>
        [XmlElement("valid")]
        public string Valid { get; set; }
    }
}
