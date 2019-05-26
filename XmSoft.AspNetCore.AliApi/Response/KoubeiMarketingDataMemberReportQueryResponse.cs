using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataMemberReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMemberReportQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询成功时返回json格式数据
        /// </summary>
        [XmlElement("report_data")]
        public string ReportData { get; set; }
    }
}
