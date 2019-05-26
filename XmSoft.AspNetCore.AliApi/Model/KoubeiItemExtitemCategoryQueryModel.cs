using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemCategoryQueryModel : AliApiObject
    {
        /// <summary>
        /// 父品类编码. (查询顶级类目时值传0)
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }
    }
}
