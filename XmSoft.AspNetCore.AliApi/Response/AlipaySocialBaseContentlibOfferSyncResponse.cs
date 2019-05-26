using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseContentlibOfferSyncResponse.
    /// </summary>
    public class AlipaySocialBaseContentlibOfferSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 返回数据放在这里，使用json
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
