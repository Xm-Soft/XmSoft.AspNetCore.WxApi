using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedExtensionBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 扩展区套数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 扩展区信息
        /// </summary>
        [XmlArray("extensions")]
        [XmlArrayItem("query_extension")]
        public List<QueryExtension> Extensions { get; set; }
    }
}
