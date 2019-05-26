using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayWeiboPucChargeResponse.
    /// </summary>
    public class AlipayWeiboPucChargeResponse : AliApiResponse
    {
        /// <summary>
        /// 返回页面内容
        /// </summary>
        [XmlElement("partnerpuccharge")]
        public string Partnerpuccharge { get; set; }
    }
}
