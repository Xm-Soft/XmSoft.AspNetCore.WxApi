using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosStallModifyResponse.
    /// </summary>
    public class KoubeiCateringPosStallModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 档口id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
