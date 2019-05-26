using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoQueryResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询返回结果：开票资料
        /// </summary>
        [XmlElement("result_set")]
        public UserInvoiceInfoOpenApiResponse ResultSet { get; set; }
    }
}
