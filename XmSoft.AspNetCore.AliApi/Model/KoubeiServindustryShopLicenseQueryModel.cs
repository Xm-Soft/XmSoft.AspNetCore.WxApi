using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiServindustryShopLicenseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryShopLicenseQueryModel : AliApiObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
