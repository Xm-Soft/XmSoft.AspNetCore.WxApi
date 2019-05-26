using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 模板详情列表
        /// </summary>
        [XmlElement("data")]
        public FengdieTemplateListRespModel Data { get; set; }
    }
}
