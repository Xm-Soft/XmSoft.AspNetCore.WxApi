using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PosCookDishQryModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosCookDishQryModel : AliApiObject
    {
        /// <summary>
        /// 菜类的list，返回的是售卖类别的ID
        /// </summary>
        [XmlArray("cate_list")]
        [XmlArrayItem("pos_cook_dish_cate_model")]
        public List<PosCookDishCateModel> CateList { get; set; }

        /// <summary>
        /// 菜品详情列表
        /// </summary>
        [XmlArray("dish_list")]
        [XmlArrayItem("pos_cook_dish_qry_detail_model")]
        public List<PosCookDishQryDetailModel> DishList { get; set; }
    }
}
