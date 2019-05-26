using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeModifyResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
