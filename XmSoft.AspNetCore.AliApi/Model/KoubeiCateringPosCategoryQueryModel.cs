using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryQueryModel : AliApiObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
