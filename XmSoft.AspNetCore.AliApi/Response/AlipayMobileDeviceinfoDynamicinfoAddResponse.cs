using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileDeviceinfoDynamicinfoAddResponse.
    /// </summary>
    public class AlipayMobileDeviceinfoDynamicinfoAddResponse : AliApiResponse
    {
        /// <summary>
        /// 同步处理结果
        /// </summary>
        [XmlElement("operateresult")]
        public bool Operateresult { get; set; }
    }
}
