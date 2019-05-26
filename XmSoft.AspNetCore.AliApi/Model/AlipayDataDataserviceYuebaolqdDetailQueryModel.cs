using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayDataDataserviceYuebaolqdDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceYuebaolqdDetailQueryModel : AliApiObject
    {
        /// <summary>
        /// 服务入参，格式为yyyymmdd
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
