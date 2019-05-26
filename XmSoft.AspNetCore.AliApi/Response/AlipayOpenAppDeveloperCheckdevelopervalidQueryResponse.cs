using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppDeveloperCheckdevelopervalidQueryResponse.
    /// </summary>
    public class AlipayOpenAppDeveloperCheckdevelopervalidQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝账号入驻开放平台有效性检查，true表示有效，false无效
        /// </summary>
        [XmlElement("dev_valid")]
        public bool DevValid { get; set; }
    }
}
