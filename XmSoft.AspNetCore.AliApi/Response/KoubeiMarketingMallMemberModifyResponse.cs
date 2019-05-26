using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingMallMemberModifyResponse.
    /// </summary>
    public class KoubeiMarketingMallMemberModifyResponse : AliApiResponse
    {
        /// <summary>
        /// true：成功，false：失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
