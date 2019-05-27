using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// QueryInstBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QueryInstBillDetail : AliApiObject
    {
        /// <summary>
        /// 明细key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 明细描述
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 明细对应值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}