using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// UseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UseRuleInfo : AliApiObject
    {
        /// <summary>
        /// 适用门店列表
        /// </summary>
        [XmlArray("suitable_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitableShops { get; set; }

        /// <summary>
        /// 核销方式
        /// </summary>
        [XmlArray("use_mode")]
        [XmlArrayItem("string")]
        public List<string> UseMode { get; set; }
    }
}
