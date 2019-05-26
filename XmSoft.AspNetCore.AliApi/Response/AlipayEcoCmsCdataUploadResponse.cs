using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoCmsCdataUploadResponse.
    /// </summary>
    public class AlipayEcoCmsCdataUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 投放消息ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
