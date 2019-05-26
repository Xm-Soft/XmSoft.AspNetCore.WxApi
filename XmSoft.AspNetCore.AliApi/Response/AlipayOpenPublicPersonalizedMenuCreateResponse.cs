using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedMenuCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 该套个性化菜单key
        /// </summary>
        [XmlElement("menu_key")]
        public string MenuKey { get; set; }
    }
}
