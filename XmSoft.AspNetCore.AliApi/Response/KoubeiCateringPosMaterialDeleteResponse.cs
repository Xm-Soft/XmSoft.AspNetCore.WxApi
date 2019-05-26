using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialDeleteResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
