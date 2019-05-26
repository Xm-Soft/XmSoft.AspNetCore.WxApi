using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ExtCategory Data Structure.
    /// </summary>
    [Serializable]
    public class ExtCategory : AliApiObject
    {
        /// <summary>
        /// 品类编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父品类编码。顶级类目此值为0
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }
    }
}
