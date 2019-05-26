using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicPartnerMenuQueryResponse.
    /// </summary>
    public class AlipayOpenPublicPartnerMenuQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 服务窗菜单
        /// </summary>
        [XmlElement("public_menu")]
        public string PublicMenu { get; set; }
    }
}
