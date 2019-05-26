using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodCommonConsultResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodCommonConsultResponse : AliApiResponse
    {
        /// <summary>
        /// 具体内容按照业务类型对应的key值传输
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
