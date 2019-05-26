using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAlipaySecurityProdTestModel : AliApiObject
    {
        /// <summary>
        /// ddd
        /// </summary>
        [XmlArray("cds")]
        [XmlArrayItem("string")]
        public List<string> Cds { get; set; }

        /// <summary>
        /// aaa
        /// </summary>
        [XmlElement("ddd")]
        public string Ddd { get; set; }
    }
}
