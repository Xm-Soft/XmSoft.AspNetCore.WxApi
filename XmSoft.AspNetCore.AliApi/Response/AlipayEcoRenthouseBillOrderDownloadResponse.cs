using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderDownloadResponse.
    /// </summary>
    public class AlipayEcoRenthouseBillOrderDownloadResponse : AliApiResponse
    {
        /// <summary>
        /// 状态值（等级值、未授权、未知）
        /// </summary>
        [XmlElement("status_value")]
        public string StatusValue { get; set; }
    }
}
