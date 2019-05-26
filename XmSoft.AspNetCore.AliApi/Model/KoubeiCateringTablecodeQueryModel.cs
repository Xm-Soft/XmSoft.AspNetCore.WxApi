using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringTablecodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringTablecodeQueryModel : AliApiObject
    {
        /// <summary>
        /// 用户在isv界面通过扫一扫传入的url文本
        /// </summary>
        [XmlElement("url_context")]
        public string UrlContext { get; set; }
    }
}
