using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdDeviceinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityProdDeviceinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// device_info，查询返回的设备数据字段JSON字符串
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// risk_info，查询返回的设备风险字段JSON字符串
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }
    }
}
