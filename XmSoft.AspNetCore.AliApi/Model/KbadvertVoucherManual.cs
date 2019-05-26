using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbadvertVoucherManual Data Structure.
    /// </summary>
    [Serializable]
    public class KbadvertVoucherManual : AliApiObject
    {
        /// <summary>
        /// 说明
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
