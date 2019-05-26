using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ReportErrorFeature Data Structure.
    /// </summary>
    [Serializable]
    public class ReportErrorFeature : AliApiObject
    {
        /// <summary>
        /// 桌号
        /// </summary>
        [XmlElement("table_num")]
        public string TableNum { get; set; }
    }
}
