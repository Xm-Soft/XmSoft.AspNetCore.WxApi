using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozIdentificationDeviceinfoQueryResponse.
    /// </summary>
    public class ZolozIdentificationDeviceinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// device_info
        /// </summary>
        [XmlElement("device_info")]
        public ZolozDeviceInfo DeviceInfo { get; set; }
    }
}
