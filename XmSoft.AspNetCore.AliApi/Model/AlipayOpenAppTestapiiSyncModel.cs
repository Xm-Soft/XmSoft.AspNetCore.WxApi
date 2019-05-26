using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppTestapiiSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestapiiSyncModel : AliApiObject
    {
        /// <summary>
        /// v
        /// </summary>
        [XmlElement("in_1")]
        public string In1 { get; set; }

        /// <summary>
        /// b
        /// </summary>
        [XmlElement("in_2")]
        public string In2 { get; set; }
    }
}
