using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceDataMonitordeviceQualitycenterModifyResponse.
    /// </summary>
    public class AlipayCommerceDataMonitordeviceQualitycenterModifyResponse : AliApiResponse
    {
        /// <summary>
        /// error_detail，出错的情况下返回，包含具体信息。
        /// </summary>
        [XmlElement("error_detail")]
        public string ErrorDetail { get; set; }
    }
}
