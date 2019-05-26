using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MyObjectDdd Data Structure.
    /// </summary>
    [Serializable]
    public class MyObjectDdd : AliApiObject
    {
        /// <summary>
        /// xx
        /// </summary>
        [XmlElement("item")]
        public string Item { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("param")]
        public string Param { get; set; }
    }
}
