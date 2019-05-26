using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayBossProdArrangementOfflineQueryResponse.
    /// </summary>
    public class AlipayBossProdArrangementOfflineQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 商户的签约状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
