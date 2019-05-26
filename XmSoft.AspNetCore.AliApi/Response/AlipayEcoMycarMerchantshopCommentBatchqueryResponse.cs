using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarMerchantshopCommentBatchqueryResponse.
    /// </summary>
    public class AlipayEcoMycarMerchantshopCommentBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 评论信息
        /// </summary>
        [XmlArray("comment_result")]
        [XmlArrayItem("merchantshop_comment_result")]
        public List<MerchantshopCommentResult> CommentResult { get; set; }

        /// <summary>
        /// 评论统计信息
        /// </summary>
        [XmlElement("comment_statistic")]
        public MerchantshopCommentStatistic CommentStatistic { get; set; }
    }
}
