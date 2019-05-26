using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdiePreviewQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdiePreviewQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 站点页面预览数据返回值
        /// </summary>
        [XmlElement("data")]
        public FengdiePreviewQueryRespModel Data { get; set; }
    }
}
