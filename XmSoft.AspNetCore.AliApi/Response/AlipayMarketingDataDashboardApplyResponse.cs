using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingDataDashboardApplyResponse.
    /// </summary>
    public class AlipayMarketingDataDashboardApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 授权失败列表
        /// </summary>
        [XmlArray("dashboard_fail_list")]
        [XmlArrayItem("string")]
        public List<string> DashboardFailList { get; set; }

        /// <summary>
        /// 授权状态
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
