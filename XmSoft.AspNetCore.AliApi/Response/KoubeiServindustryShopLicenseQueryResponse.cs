using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiServindustryShopLicenseQueryResponse.
    /// </summary>
    public class KoubeiServindustryShopLicenseQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 有一家shop有营业执照：true  所有shop无营业执照：false
        /// </summary>
        [XmlElement("have_permit")]
        public bool HavePermit { get; set; }
    }
}
