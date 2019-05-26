using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandItemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemCreateModel : AliApiObject
    {
        /// <summary>
        /// 商品扩展信息：可以解析成 Map<String, String> 的 json string
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 前台类目id：target_type + target_id 和 front_category_id 二选一
        /// </summary>
        [XmlElement("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品标签列表
        /// </summary>
        [XmlArray("label_list")]
        [XmlArrayItem("item_label_create_info")]
        public List<ItemLabelCreateInfo> LabelList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 场景：GAS_CHARGE（加油）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品sku列表，至少有一个
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("item_sku_create_info")]
        public List<ItemSkuCreateInfo> SkuList { get; set; }

        /// <summary>
        /// 商户归属主体id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型：target_type + target_id 和 front_category_id 二选一    商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
