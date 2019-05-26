using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoEduKtStudentModifyResponse.
    /// </summary>
    public class AlipayEcoEduKtStudentModifyResponse : AliApiResponse
    {
        /// <summary>
        /// Y：代表成功；N：代表失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
