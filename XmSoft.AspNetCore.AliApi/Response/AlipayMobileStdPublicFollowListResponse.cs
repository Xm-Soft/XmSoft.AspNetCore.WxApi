using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileStdPublicFollowListResponse.
    /// </summary>
    public class AlipayMobileStdPublicFollowListResponse : AliApiResponse
    {
        /// <summary>
        /// 当前组的值
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 用户数据
        /// </summary>
        [XmlElement("data")]
        public Data Data { get; set; }

        /// <summary>
        /// 与nextUserId对应，标准Alipay UserId
        /// </summary>
        [XmlElement("next_alipay_user_id")]
        public string NextAlipayUserId { get; set; }

        /// <summary>
        /// 查询分组的userid
        /// </summary>
        [XmlElement("next_user_id")]
        public string NextUserId { get; set; }
    }
}
