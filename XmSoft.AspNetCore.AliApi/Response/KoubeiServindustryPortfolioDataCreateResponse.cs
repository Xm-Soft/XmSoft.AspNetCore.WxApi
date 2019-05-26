using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioDataCreateResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioDataCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 作品集ID
        /// </summary>
        [XmlElement("portfolio_id")]
        public string PortfolioId { get; set; }
    }
}
