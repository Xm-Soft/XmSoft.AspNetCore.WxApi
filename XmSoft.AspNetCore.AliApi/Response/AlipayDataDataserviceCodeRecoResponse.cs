using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceCodeRecoResponse.
    /// </summary>
    public class AlipayDataDataserviceCodeRecoResponse : AliApiResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlElement("result")]
        public AlipayCodeRecoResult Result { get; set; }
    }
}
