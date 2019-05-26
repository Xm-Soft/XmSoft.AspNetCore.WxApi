using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 菜类信息
        /// </summary>
        [XmlElement("dish_category_entity")]
        public DishCategoryEntity DishCategoryEntity { get; set; }
    }
}
