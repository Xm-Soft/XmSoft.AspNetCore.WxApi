using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicDefaultExtensionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicDefaultExtensionCreateModel : AliApiObject
    {
        /// <summary>
        /// 默认扩展区列表，最多包含3个扩展区
        /// </summary>
        [XmlArray("areas")]
        [XmlArrayItem("extension_area")]
        public List<ExtensionArea> Areas { get; set; }
    }
}
