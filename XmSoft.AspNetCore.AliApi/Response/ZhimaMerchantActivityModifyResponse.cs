using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaMerchantActivityModifyResponse.
    /// </summary>
    public class ZhimaMerchantActivityModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 芝麻活动号
        /// </summary>
        [XmlElement("activity_no")]
        public string ActivityNo { get; set; }
    }
}
