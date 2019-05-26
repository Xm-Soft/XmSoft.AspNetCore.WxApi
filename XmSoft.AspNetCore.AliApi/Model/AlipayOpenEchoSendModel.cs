using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenEchoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenEchoSendModel : AliApiObject
    {
        /// <summary>
        /// city
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
