using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollcertifyQueryResponse.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollcertifyQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
