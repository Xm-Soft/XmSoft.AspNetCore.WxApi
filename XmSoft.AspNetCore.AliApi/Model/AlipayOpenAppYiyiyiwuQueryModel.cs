using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppYiyiyiwuQueryModel : AliApiObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("rucan")]
        public string Rucan { get; set; }
    }
}
