using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosStallCreateResponse.
    /// </summary>
    public class KoubeiCateringPosStallCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 档口id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
