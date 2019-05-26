using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCreateResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
