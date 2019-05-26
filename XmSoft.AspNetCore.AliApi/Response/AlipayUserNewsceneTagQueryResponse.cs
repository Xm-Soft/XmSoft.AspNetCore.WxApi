using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserNewsceneTagQueryResponse.
    /// </summary>
    public class AlipayUserNewsceneTagQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 对于传入的tag进行输出，格式为json，true表示是 fasle表示否，invalid表示无法判断，例如传入的账号不存在
        /// </summary>
        [XmlElement("tags_result")]
        public string TagsResult { get; set; }
    }
}
