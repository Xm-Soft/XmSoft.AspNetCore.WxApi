using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataAlisisReportQueryModel : AliApiObject
    {
        /// <summary>
        /// 报表查询过滤条件
        /// </summary>
        [XmlArray("conditions")]
        [XmlArrayItem("report_query_condition")]
        public List<ReportQueryCondition> Conditions { get; set; }

        /// <summary>
        /// 报表唯一标识
        /// </summary>
        [XmlElement("report_uk")]
        public string ReportUk { get; set; }
    }
}
