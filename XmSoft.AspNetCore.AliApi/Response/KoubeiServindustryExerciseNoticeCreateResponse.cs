using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiServindustryExerciseNoticeCreateResponse.
    /// </summary>
    public class KoubeiServindustryExerciseNoticeCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 通知ID
        /// </summary>
        [XmlElement("notice_id")]
        public string NoticeId { get; set; }
    }
}
