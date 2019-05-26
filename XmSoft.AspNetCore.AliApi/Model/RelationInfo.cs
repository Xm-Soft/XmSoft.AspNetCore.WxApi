using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// RelationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RelationInfo : AliApiObject
    {
        /// <summary>
        /// 关系新鲜度，如V_CT_RL30D（最近30天有联系）详细描述见产品文档。
        /// </summary>
        [XmlElement("recency")]
        public string Recency { get; set; }
    }
}
