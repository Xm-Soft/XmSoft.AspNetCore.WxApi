using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskHideDeviceidQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskHideDeviceidQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 设备指纹的apdid
        /// </summary>
        [XmlElement("deviceid")]
        public string Deviceid { get; set; }
    }
}
