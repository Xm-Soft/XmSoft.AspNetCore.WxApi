using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDpcAlisisOlapprocessorResponse.
    /// </summary>
    public class AlipayDataDpcAlisisOlapprocessorResponse : AliApiResponse
    {
        /// <summary>
        /// 业务处理后返回的数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
