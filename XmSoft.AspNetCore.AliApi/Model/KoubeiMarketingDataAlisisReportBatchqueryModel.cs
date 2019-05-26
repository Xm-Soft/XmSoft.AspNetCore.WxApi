using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataAlisisReportBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 每页最大条数，最大为30
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }
    }
}
