using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotedetailChannelBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotedetailChannelBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("promote_detail_channel_model")]
        public List<PromoteDetailChannelModel> Data { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
