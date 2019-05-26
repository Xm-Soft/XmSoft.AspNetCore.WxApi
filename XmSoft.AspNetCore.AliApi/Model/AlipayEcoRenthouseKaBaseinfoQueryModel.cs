using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseKaBaseinfoQueryModel : AliApiObject
    {
        /// <summary>
        /// kaCode唯一标识
        /// </summary>
        [XmlElement("ka_code")]
        public string KaCode { get; set; }
    }
}
