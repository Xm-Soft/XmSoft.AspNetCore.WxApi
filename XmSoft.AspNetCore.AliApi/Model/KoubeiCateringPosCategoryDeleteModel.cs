using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosCategoryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryDeleteModel : AliApiObject
    {
        /// <summary>
        /// 菜类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
