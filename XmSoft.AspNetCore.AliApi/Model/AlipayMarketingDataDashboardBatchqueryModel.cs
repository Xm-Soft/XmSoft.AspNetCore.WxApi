using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingDataDashboardBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataDashboardBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 每页最大条数，最大每页30条
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }
    }
}
