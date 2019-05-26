using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySamsungEbppRechargeResponse.
    /// </summary>
    public class AlipaySamsungEbppRechargeResponse : AliApiResponse
    {
        /// <summary>
        /// 直接返回页面
        /// </summary>
        [XmlElement("page_retrun")]
        public string PageRetrun { get; set; }
    }
}
