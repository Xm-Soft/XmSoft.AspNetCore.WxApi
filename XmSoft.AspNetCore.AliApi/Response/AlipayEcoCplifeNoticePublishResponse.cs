using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoCplifeNoticePublishResponse.
    /// </summary>
    public class AlipayEcoCplifeNoticePublishResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝平台统一生产的通知公告唯一ID标示.
        /// </summary>
        [XmlElement("notice_id")]
        public string NoticeId { get; set; }
    }
}
