using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchqueryResponse.
    /// </summary>
    public class AlipayInsMarketingCertificateBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 分页查询结果
        /// </summary>
        [XmlElement("ins_certificate_pagination_list")]
        public InsCertificatePaginationList InsCertificatePaginationList { get; set; }
    }
}
