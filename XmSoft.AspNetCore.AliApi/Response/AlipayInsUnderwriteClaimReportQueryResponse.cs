using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsUnderwriteClaimReportQueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteClaimReportQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 案件信息
        /// </summary>
        [XmlArray("reports")]
        [XmlArrayItem("ins_claim_report")]
        public List<InsClaimReport> Reports { get; set; }
    }
}
