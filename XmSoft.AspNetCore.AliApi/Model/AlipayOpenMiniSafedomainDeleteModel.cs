using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenMiniSafedomainDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniSafedomainDeleteModel : AliApiObject
    {
        /// <summary>
        /// httpRequest域白名单
        /// </summary>
        [XmlElement("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
