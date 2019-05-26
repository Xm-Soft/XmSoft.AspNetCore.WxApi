using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenDataItemRecommendBatchqueryResponse.
    /// </summary>
    public class AlipayOpenDataItemRecommendBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 推荐结果
        /// </summary>
        [XmlArray("result_obj")]
        [XmlArrayItem("rec_result_info")]
        public List<RecResultInfo> ResultObj { get; set; }
    }
}
