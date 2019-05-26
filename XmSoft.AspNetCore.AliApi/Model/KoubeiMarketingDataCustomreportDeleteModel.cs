using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportDeleteModel : AliApiObject
    {
        /// <summary>
        /// 自定义报表规则的KEY
        /// </summary>
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }
    }
}
