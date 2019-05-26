using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicUserDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicUserDataBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户分析数据
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("user_analysis_data")]
        public List<UserAnalysisData> DataList { get; set; }
    }
}
