using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 外部商品信息
        /// </summary>
        [XmlElement("kb_ext_item_info")]
        public KbExtItemInfo KbExtItemInfo { get; set; }
    }
}
