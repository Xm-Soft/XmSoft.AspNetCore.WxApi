using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMdataTagGetResponse.
    /// </summary>
    public class AlipayMdataTagGetResponse : AliApiResponse
    {
        /// <summary>
        /// 查询到的标签值, JSON字符串
        /// </summary>
        [XmlElement("tag_values")]
        public string TagValues { get; set; }
    }
}
