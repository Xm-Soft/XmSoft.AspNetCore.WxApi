using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeCreateResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
