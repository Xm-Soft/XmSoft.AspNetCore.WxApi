using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingDataDashboardQueryResponse.
    /// </summary>
    public class AlipayMarketingDataDashboardQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 仪表盘访问地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
