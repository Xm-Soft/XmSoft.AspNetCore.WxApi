using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosSidedishbatchSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosSidedishbatchSaveModel : AliApiObject
    {
        /// <summary>
        /// 需要添加配菜的菜品ID
        /// </summary>
        [XmlArray("dish_ids")]
        [XmlArrayItem("string")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 批量添加的配菜
        /// </summary>
        [XmlArray("dish_material_list")]
        [XmlArrayItem("pos_dish_material_model")]
        public List<PosDishMaterialModel> DishMaterialList { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
