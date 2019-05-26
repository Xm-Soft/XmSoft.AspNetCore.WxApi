using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppXwbtestabcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppXwbtestabcQueryModel : AliApiObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("testabc")]
        public string Testabc { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xwb")]
        public string Xwb { get; set; }
    }
}
