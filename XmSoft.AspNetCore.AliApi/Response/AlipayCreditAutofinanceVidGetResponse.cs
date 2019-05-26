using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceVidGetResponse.
    /// </summary>
    public class AlipayCreditAutofinanceVidGetResponse : AliApiResponse
    {
        /// <summary>
        /// 核身VID
        /// </summary>
        [XmlElement("verifyid")]
        public string Verifyid { get; set; }
    }
}
