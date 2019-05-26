using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuUserQueryResponse.
    /// </summary>
    public class AlipayMobilePublicMenuUserQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 菜单唯一标识
        /// </summary>
        [XmlElement("menu_key")]
        public string MenuKey { get; set; }

        /// <summary>
        /// 结果码描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
