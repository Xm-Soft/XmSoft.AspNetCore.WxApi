using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotesummaryDateBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotesummaryDateBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑客推广日期维度汇总数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("promote_date_model")]
        public List<PromoteDateModel> Data { get; set; }
    }
}
