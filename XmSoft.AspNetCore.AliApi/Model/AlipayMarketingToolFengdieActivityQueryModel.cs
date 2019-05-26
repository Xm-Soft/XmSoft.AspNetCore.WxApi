using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieActivityQueryModel : AliApiObject
    {
        /// <summary>
        /// H5应用的唯一id，调用alipay.marketing.tool.fengdie.activity.create获得
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }
    }
}
