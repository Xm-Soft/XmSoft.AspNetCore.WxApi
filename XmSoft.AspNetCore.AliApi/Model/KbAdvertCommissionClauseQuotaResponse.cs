using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbAdvertCommissionClauseQuotaResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCommissionClauseQuotaResponse : AliApiObject
    {
        /// <summary>
        /// 分佣定额(精度2位的非负小数)
        /// </summary>
        [XmlElement("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
