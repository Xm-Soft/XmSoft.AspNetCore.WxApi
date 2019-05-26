using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicUserFollowQueryResponse.
    /// </summary>
    public class AlipayOpenPublicUserFollowQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户是否关注，T代表已关注，F代表未关注
        /// </summary>
        [XmlElement("is_follow")]
        public string IsFollow { get; set; }
    }
}
