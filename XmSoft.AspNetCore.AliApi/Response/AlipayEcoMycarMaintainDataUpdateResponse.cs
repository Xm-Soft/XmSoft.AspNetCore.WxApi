using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainDataUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainDataUpdateResponse : AliApiResponse
    {
        /// <summary>
        /// 具体返回的处理结果
        /// </summary>
        [XmlElement("info")]
        public string Info { get; set; }
    }
}
