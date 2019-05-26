using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosSpecSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosSpecSyncModel : AliApiObject
    {
        /// <summary>
        /// 菜品规格信息
        /// </summary>
        [XmlElement("spec")]
        public SpecEntity Spec { get; set; }

        /// <summary>
        /// 规格ids,删除时传
        /// </summary>
        [XmlArray("spec_ids")]
        [XmlArrayItem("string")]
        public List<string> SpecIds { get; set; }

        /// <summary>
        /// 操作类型 add 新增，update 修改，del 删除 ，其他返回null
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
