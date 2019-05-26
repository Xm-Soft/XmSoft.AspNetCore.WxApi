using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicXwbtestabcdBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 1111112141414
        /// </summary>
        [XmlElement("s")]
        public string S { get; set; }
    }
}
