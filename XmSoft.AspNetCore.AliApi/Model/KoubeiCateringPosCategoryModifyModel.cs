using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosCategoryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryModifyModel : AliApiObject
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 菜类名称
        /// </summary>
        [XmlElement("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
