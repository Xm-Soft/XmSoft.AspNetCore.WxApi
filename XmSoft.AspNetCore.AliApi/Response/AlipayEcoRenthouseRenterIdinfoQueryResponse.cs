using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoRenthouseRenterIdinfoQueryResponse.
    /// </summary>
    public class AlipayEcoRenthouseRenterIdinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 状态值（已授权、未授权、未知）
        /// </summary>
        [XmlElement("status_value")]
        public string StatusValue { get; set; }
    }
}
