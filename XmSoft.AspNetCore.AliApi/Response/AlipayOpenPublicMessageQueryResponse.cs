using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageQueryResponse.
    /// </summary>
    public class AlipayOpenPublicMessageQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 发送消息结果集。仅返回该用户已发送的消息
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("public_message_info")]
        public List<PublicMessageInfo> List { get; set; }
    }
}
