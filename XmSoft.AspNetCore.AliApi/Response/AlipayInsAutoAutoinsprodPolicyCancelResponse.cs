using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyCancelResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyCancelResponse : AliApiResponse
    {
        /// <summary>
        /// 操作结果 true/false
        /// </summary>
        [XmlElement("cancel_result")]
        public string CancelResult { get; set; }
    }
}
