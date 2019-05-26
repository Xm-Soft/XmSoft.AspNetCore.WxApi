using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
