using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeOfflineResponse.
    /// </summary>
    public class AlipayCommerceTransportAdCreativeOfflineResponse : AliApiResponse
    {
        /// <summary>
        /// 创意下线结果 + 根据创意id操作创意下线，成功返回true，失败返回false
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
