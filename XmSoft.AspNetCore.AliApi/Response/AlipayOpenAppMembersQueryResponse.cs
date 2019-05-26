using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppMembersQueryResponse.
    /// </summary>
    public class AlipayOpenAppMembersQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 小程序成员模型
        /// </summary>
        [XmlArray("app_member_info_list")]
        [XmlArrayItem("app_member_info")]
        public List<AppMemberInfo> AppMemberInfoList { get; set; }
    }
}
