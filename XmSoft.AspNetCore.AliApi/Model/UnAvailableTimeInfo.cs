using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// UnAvailableTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UnAvailableTimeInfo : AliApiObject
    {
        /// <summary>
        /// 起始时间
        /// </summary>
        [XmlElement("from_date")]
        public string FromDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("to_date")]
        public string ToDate { get; set; }
    }
}
