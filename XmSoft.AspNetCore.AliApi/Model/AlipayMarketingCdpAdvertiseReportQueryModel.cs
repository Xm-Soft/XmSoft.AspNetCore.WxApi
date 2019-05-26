using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCdpAdvertiseReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCdpAdvertiseReportQueryModel : AliApiObject
    {
        /// <summary>
        /// 广告Id，唯一标识一条广告
        /// </summary>
        [XmlElement("ad_id")]
        public string AdId { get; set; }
    }
}
