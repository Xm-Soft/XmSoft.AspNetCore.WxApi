using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicContactFollowBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicContactFollowBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 联系人关注者列表
        /// </summary>
        [XmlArray("contact_follow_list")]
        [XmlArrayItem("contact_follower")]
        public List<ContactFollower> ContactFollowList { get; set; }
    }
}
