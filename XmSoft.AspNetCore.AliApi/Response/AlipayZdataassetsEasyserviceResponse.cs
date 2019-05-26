using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayZdataassetsEasyserviceResponse.
    /// </summary>
    public class AlipayZdataassetsEasyserviceResponse : AliApiResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
