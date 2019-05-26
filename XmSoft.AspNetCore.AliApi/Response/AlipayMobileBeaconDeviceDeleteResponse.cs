using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceDeleteResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 操作返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 请求处理结果
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
