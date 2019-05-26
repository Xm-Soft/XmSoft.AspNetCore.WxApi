using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserInviteOnlinesummaryQueryResponse.
    /// </summary>
    public class AlipayUserInviteOnlinesummaryQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 线上拉新结算汇总数据列表
        /// </summary>
        [XmlArray("online_summary_info_list")]
        [XmlArrayItem("online_invite_newer_summary_info")]
        public List<OnlineInviteNewerSummaryInfo> OnlineSummaryInfoList { get; set; }
    }
}
