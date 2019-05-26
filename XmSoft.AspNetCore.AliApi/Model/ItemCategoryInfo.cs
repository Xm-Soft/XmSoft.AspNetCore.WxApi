using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ItemCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCategoryInfo : AliApiObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类目层级
        /// </summary>
        [XmlElement("category_level")]
        public long CategoryLevel { get; set; }
    }
}
