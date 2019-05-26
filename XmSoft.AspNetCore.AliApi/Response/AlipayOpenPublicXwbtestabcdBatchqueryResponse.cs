using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }
    }
}
