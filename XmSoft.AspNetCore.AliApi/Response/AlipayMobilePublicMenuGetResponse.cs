using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuGetResponse.
    /// </summary>
    public class AlipayMobilePublicMenuGetResponse : AliApiResponse
    {
        /// <summary>
        /// success
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 菜单内容
        /// </summary>
        [XmlElement("menu_content")]
        public string MenuContent { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
