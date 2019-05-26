using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// BizParamKeyValue Data Structure.
    /// </summary>
    [Serializable]
    public class BizParamKeyValue : AliApiObject
    {
        /// <summary>
        /// 参数名key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数值value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
