using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayTradeCustomsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCustomsQueryModel : AliApiObject
    {
        /// <summary>
        /// 报关请求号。需要查询的商户端报关请求号，支持批量查询，  多个值用英文半角逗号分隔，单次请求最多10个;
        /// </summary>
        [XmlElement("out_request_nos")]
        public string OutRequestNos { get; set; }
    }
}
