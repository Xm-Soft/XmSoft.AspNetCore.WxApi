using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayHighValueCustomerResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayHighValueCustomerResult : AliApiObject
    {
        /// <summary>
        /// Z0-Z7
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }
    }
}
