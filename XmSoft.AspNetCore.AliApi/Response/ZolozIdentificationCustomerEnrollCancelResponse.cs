using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollCancelResponse.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollCancelResponse : AliApiResponse
    {
        /// <summary>
        /// 与入参值保持一致
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
