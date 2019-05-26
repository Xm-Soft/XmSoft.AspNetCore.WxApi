using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppSilanApigrayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSilanApigrayQueryModel : AliApiObject
    {
        /// <summary>
        /// param
        /// </summary>
        [XmlElement("param_1")]
        public string Param1 { get; set; }
    }
}
