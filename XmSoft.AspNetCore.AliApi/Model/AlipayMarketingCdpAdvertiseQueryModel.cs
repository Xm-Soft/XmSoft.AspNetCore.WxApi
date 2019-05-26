using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCdpAdvertiseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCdpAdvertiseQueryModel : AliApiObject
    {
        /// <summary>
        /// 广告Id，唯一标识一条广告
        /// </summary>
        [XmlElement("ad_id")]
        public string AdId { get; set; }
    }
}
