using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialCreateResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
