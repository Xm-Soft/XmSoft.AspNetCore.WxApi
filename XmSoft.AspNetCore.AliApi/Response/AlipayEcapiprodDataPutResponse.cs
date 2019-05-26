using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcapiprodDataPutResponse.
    /// </summary>
    public class AlipayEcapiprodDataPutResponse : AliApiResponse
    {
        /// <summary>
        /// 数据版本
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }
    }
}
