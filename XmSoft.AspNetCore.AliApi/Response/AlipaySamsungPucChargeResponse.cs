using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySamsungPucChargeResponse.
    /// </summary>
    public class AlipaySamsungPucChargeResponse : AliApiResponse
    {
        /// <summary>
        /// zhijiefanhui yemian
        /// </summary>
        [XmlElement("page_retrun")]
        public string PageRetrun { get; set; }
    }
}
