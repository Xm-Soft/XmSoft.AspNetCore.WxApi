using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDiscoveryTaxiOrderConfirmResponse.
    /// </summary>
    public class AlipayDiscoveryTaxiOrderConfirmResponse : AliApiResponse
    {
        /// <summary>
        /// 返回结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
