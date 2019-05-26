using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// XwbTestData Data Structure.
    /// </summary>
    [Serializable]
    public class XwbTestData : AliApiObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s")]
        public string S { get; set; }
    }
}
