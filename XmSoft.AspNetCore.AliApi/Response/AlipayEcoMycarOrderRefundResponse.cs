using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarOrderRefundResponse.
    /// </summary>
    public class AlipayEcoMycarOrderRefundResponse : AliApiResponse
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 是否成功(T: 成功，F:失败)
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
