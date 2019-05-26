using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportSaveResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportSaveResponse : AliApiResponse
    {
        /// <summary>
        /// 自定义报表的规则ID
        /// </summary>
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }
    }
}
