using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishRecommendQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRecommendQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 推荐菜品列表
        /// </summary>
        [XmlArray("dish_list")]
        [XmlArrayItem("dish_recommend")]
        public List<DishRecommend> DishList { get; set; }
    }
}
