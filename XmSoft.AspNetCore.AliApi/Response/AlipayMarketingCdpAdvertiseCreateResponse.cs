using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCdpAdvertiseCreateResponse.
    /// </summary>
    public class AlipayMarketingCdpAdvertiseCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 创建广告唯一标识
        /// </summary>
        [XmlElement("ad_id")]
        public string AdId { get; set; }
    }
}
