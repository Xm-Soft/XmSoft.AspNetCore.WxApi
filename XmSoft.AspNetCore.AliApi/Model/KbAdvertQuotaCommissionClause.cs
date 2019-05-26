using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbAdvertQuotaCommissionClause Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertQuotaCommissionClause : AliApiObject
    {
        /// <summary>
        /// 固定金额
        /// </summary>
        [XmlElement("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
