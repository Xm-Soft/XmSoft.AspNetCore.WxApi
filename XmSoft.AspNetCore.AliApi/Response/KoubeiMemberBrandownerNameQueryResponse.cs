using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMemberBrandownerNameQueryResponse.
    /// </summary>
    public class KoubeiMemberBrandownerNameQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 品牌商名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
