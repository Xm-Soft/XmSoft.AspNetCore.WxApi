using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmileliveInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerSmileliveInitializeResponse : AliApiResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
