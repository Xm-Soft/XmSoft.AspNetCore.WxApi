using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingToolIsvMerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolIsvMerchantQueryModel : AliApiObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
