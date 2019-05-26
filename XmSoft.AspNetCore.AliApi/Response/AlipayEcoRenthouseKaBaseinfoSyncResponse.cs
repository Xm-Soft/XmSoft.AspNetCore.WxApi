using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoSyncResponse.
    /// </summary>
    public class AlipayEcoRenthouseKaBaseinfoSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 返回kaCode唯一标识,用户查询ka信息时候用
        /// </summary>
        [XmlElement("ka_code")]
        public string KaCode { get; set; }
    }
}
