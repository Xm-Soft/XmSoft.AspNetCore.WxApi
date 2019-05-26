using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询返回结果：发票信息
        /// </summary>
        [XmlElement("result_set")]
        public ArInvoiceOpenApiResponse ResultSet { get; set; }
    }
}
