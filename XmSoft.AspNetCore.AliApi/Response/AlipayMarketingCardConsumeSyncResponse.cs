using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCardConsumeSyncResponse.
    /// </summary>
    public class AlipayMarketingCardConsumeSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 外部卡号
        /// </summary>
        [XmlElement("external_card_no")]
        public string ExternalCardNo { get; set; }
    }
}
