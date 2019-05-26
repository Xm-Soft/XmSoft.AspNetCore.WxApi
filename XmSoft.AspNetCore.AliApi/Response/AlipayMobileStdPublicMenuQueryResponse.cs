using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileStdPublicMenuQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicMenuQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 所有菜单列表json串
        /// </summary>
        [XmlElement("all_menu_list")]
        public string AllMenuList { get; set; }
    }
}
