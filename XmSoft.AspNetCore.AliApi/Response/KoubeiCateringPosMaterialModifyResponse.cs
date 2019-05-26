using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialModifyResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
