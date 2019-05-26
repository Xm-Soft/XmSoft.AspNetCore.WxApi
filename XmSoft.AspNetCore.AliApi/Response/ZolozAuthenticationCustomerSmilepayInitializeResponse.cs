using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmilepayInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerSmilepayInitializeResponse : AliApiResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
