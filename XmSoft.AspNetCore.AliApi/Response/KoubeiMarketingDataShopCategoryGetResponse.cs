using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataShopCategoryGetResponse.
    /// </summary>
    public class KoubeiMarketingDataShopCategoryGetResponse : AliApiResponse
    {
        /// <summary>
        /// 指定数量的店铺分类信息
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("category")]
        public List<Category> CategoryList { get; set; }

        /// <summary>
        /// 剩余的店铺分类
        /// </summary>
        [XmlElement("other")]
        public Category Other { get; set; }
    }
}
