using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenCategoryArticleQueryResponse.
    /// </summary>
    public class AlipayOpenCategoryArticleQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 文章列表
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("life_recommend_articles")]
        public List<LifeRecommendArticles> Articles { get; set; }
    }
}
