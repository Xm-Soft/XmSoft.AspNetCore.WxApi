using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoCreateResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 开票资料id，唯一性ID
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
