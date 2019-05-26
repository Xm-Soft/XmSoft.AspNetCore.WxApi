using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportDetailQueryModel : AliApiObject
    {
        /// <summary>
        /// 自定义报表的规则KEY
        /// </summary>
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }
    }
}
