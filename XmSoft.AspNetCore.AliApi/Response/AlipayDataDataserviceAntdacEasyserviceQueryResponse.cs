using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdacEasyserviceQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdacEasyserviceQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 方法返回值＋json字符串格式
        /// </summary>
        [XmlElement("ret_val")]
        public string RetVal { get; set; }
    }
}
