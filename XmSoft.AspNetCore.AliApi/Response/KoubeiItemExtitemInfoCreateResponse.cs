using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoCreateResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 创建成功，返回id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
