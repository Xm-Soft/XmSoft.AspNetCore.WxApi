using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingDataDashboardBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingDataDashboardBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 仪表盘列表信息
        /// </summary>
        [XmlArray("dashboard_list")]
        [XmlArrayItem("dash_board_meta")]
        public List<DashBoardMeta> DashboardList { get; set; }

        /// <summary>
        /// 报表总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public string TotalPageCount { get; set; }
    }
}
