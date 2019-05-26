using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusCreateResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 作品列表
        /// </summary>
        [XmlElement("opuses")]
        public OpusCreateResponse Opuses { get; set; }
    }
}
