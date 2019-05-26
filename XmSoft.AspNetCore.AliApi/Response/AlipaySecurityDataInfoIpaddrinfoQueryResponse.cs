using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityDataInfoIpaddrinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityDataInfoIpaddrinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// ip_addr_lbs_info:IP地址归属地对象。其中province为IP地址归属地的省，city为IP地址归属地的城市
        /// </summary>
        [XmlElement("ip_addr_lbs_info")]
        public IpAddrLbsInfo IpAddrLbsInfo { get; set; }
    }
}
