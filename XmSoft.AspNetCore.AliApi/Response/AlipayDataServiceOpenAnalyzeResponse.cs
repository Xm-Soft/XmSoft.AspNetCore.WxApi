using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataServiceOpenAnalyzeResponse.
    /// </summary>
    public class AlipayDataServiceOpenAnalyzeResponse : AliApiResponse
    {
        /// <summary>
        /// 调用返回
        /// </summary>
        [XmlElement("result")]
        public AlipayDataServiceResult Result { get; set; }
    }
}
