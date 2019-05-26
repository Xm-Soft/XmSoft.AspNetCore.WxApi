using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 分页输出自定义开放数据规则列表
        /// </summary>
        [XmlArray("report_condition_list")]
        [XmlArrayItem("custom_report_condition")]
        public List<CustomReportCondition> ReportConditionList { get; set; }
    }
}
