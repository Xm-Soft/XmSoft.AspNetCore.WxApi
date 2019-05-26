using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbdishMaterialBindingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishMaterialBindingInfo : AliApiObject
    {
        /// <summary>
        /// 加料id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 菜品加料排序字段，从1开始递增
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
