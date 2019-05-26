using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataProviderCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataProviderCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 手艺人id
        /// </summary>
        [XmlElement("craftsman_id")]
        public string CraftsmanId { get; set; }
    }
}
