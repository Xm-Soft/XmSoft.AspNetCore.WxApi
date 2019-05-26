using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieMemberCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieMemberCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 凤蝶业务空间创建成功后，返回该成员的基本信息
        /// </summary>
        [XmlElement("data")]
        public FengdieSpaceMemberCreateModel Data { get; set; }
    }
}
