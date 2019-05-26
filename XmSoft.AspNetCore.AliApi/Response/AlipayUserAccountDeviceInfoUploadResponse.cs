using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserAccountDeviceInfoUploadResponse.
    /// </summary>
    public class AlipayUserAccountDeviceInfoUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
