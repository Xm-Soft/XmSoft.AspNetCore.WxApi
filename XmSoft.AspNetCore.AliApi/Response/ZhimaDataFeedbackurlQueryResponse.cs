using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaDataFeedbackurlQueryResponse.
    /// </summary>
    public class ZhimaDataFeedbackurlQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 反馈模板地址
        /// </summary>
        [XmlElement("feedback_url")]
        public string FeedbackUrl { get; set; }
    }
}
