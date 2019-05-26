using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ExtendFieldInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtendFieldInfo : AliApiObject
    {
        /// <summary>
        /// 字段名
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        [XmlElement("field_value")]
        public string FieldValue { get; set; }
    }
}
