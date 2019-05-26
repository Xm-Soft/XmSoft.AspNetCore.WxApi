using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayPlatformUseridGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPlatformUseridGetModel : AliApiObject
    {
        /// <summary>
        /// openId的列表
        /// </summary>
        [XmlArray("open_ids")]
        [XmlArrayItem("string")]
        public List<string> OpenIds { get; set; }
    }
}
