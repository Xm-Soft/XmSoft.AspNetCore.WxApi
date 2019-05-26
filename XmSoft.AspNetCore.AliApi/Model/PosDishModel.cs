using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PosDishModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishModel : AliApiObject
    {
        /// <summary>
        /// 菜品大类的ID，除了删除，其他情况必传
        /// </summary>
        [XmlElement("category_big_id")]
        public string CategoryBigId { get; set; }

        /// <summary>
        /// 组合菜的列表，如果是套餐，那这个必传
        /// </summary>
        [XmlArray("choose_dish_group_list")]
        [XmlArrayItem("pos_choose_dish_group_model")]
        public List<PosChooseDishGroupModel> ChooseDishGroupList { get; set; }

        /// <summary>
        /// 关联的菜谱的ID，一期的时候是必传的
        /// </summary>
        [XmlElement("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 创建者的ID，新建的时候必传
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 菜品的ID，更新和删除时候必传
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品图片ID，请使用素材库的ID
        /// </summary>
        [XmlElement("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名字，除了删除，其他情况必传
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品SKU的列表，新增，更新套餐时候是必传的  删除时可以不传
        /// </summary>
        [XmlArray("dish_sku_list")]
        [XmlArrayItem("pos_sku_model")]
        public List<PosSkuModel> DishSkuList { get; set; }

        /// <summary>
        /// 拼音助记码
        /// </summary>
        [XmlElement("en_remember_code")]
        public string EnRememberCode { get; set; }

        /// <summary>
        /// 套餐固定菜的列表，如果是套餐有固定菜，那就必传
        /// </summary>
        [XmlArray("fixed_dish_group_list")]
        [XmlArrayItem("pos_fixed_dish_group_model")]
        public List<PosFixedDishGroupModel> FixedDishGroupList { get; set; }

        /// <summary>
        /// 配料的ID列表
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("pos_dish_material_model")]
        public List<PosDishMaterialModel> MaterialList { get; set; }

        /// <summary>
        /// 最低起点份数，除了删除，其他情况必传
        /// </summary>
        [XmlElement("min_serving")]
        public long MinServing { get; set; }

        /// <summary>
        /// 数字助记码
        /// </summary>
        [XmlElement("nb_remember_code")]
        public string NbRememberCode { get; set; }

        /// <summary>
        /// 菜品做法的列表
        /// </summary>
        [XmlArray("practice_list")]
        [XmlArrayItem("pos_dish_practice_model")]
        public List<PosDishPracticeModel> PracticeList { get; set; }

        /// <summary>
        /// 菜品的描述
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 菜品售卖价格
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 打印档口的ID列表
        /// </summary>
        [XmlArray("stall_list")]
        [XmlArrayItem("pos_stall_model")]
        public List<PosStallModel> StallList { get; set; }

        /// <summary>
        /// 菜品的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作的类型，add新增 update更新 del删除
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }

        /// <summary>
        /// 标签只支持那两种
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 菜品类别single单品 packages套餐  除了删除，其他情况必传
        /// </summary>
        [XmlElement("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// fixed固定套餐 choose 组合套餐  如果是套餐类型，这个必传，删除时候，可以不传
        /// </summary>
        [XmlElement("type_small")]
        public string TypeSmall { get; set; }

        /// <summary>
        /// 菜品单位名称，除了删除，其他情况必传
        /// </summary>
        [XmlElement("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// 更新时候的用户，更新，删除操作必传
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
