using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingMallTradeBindResponse.
    /// </summary>
    public class KoubeiMarketingMallTradeBindResponse : AliApiResponse
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
