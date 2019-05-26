using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 当前页号，默认为1
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条目数，默认为20,最大为30
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
