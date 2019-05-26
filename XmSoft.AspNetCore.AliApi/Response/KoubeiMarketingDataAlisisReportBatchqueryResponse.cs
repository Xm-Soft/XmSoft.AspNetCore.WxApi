using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingDataAlisisReportBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 报表列表信息
        /// </summary>
        [XmlArray("report_list")]
        [XmlArrayItem("alisis_report")]
        public List<AlisisReport> ReportList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
