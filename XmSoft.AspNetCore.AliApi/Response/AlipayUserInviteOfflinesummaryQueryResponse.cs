using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserInviteOfflinesummaryQueryResponse.
    /// </summary>
    public class AlipayUserInviteOfflinesummaryQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 线下拉新结算汇总数据列表
        /// </summary>
        [XmlArray("offline_summary_info_list")]
        [XmlArrayItem("offline_invite_newer_summary_info")]
        public List<OfflineInviteNewerSummaryInfo> OfflineSummaryInfoList { get; set; }
    }
}
