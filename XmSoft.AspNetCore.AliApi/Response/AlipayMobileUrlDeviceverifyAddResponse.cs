using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileUrlDeviceverifyAddResponse.
    /// </summary>
    public class AlipayMobileUrlDeviceverifyAddResponse : AliApiResponse
    {
        /// <summary>
        /// 返回业务操作是否成功
        /// </summary>
        [XmlElement("response")]
        public bool Response { get; set; }
    }
}
