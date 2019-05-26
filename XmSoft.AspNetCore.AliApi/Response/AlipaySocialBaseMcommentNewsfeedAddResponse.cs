using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseMcommentNewsfeedAddResponse.
    /// </summary>
    public class AlipaySocialBaseMcommentNewsfeedAddResponse : AliApiResponse
    {
        /// <summary>
        /// 新评论id
        /// </summary>
        [XmlElement("newsfeed_id")]
        public string NewsfeedId { get; set; }
    }
}
