using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayTrustUserReportGetResponse.
    /// </summary>
    public class AlipayTrustUserReportGetResponse : AliApiResponse
    {
        /// <summary>
        /// 报告内容，格式详见示例代码
        /// </summary>
        [XmlElement("report")]
        public string Report { get; set; }
    }
}
