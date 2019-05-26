using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// BeaconTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class BeaconTemplate : AliApiObject
    {
        /// <summary>
        /// 模板参数信息
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("templateid")]
        public string Templateid { get; set; }
    }
}
