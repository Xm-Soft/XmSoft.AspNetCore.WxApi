using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// LogisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsInfo : AliApiObject
    {
        /// <summary>
        /// 物流公司code
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
