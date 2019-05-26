using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceChinaremodelQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 中再核保模型查询结果
        /// </summary>
        [XmlElement("result")]
        public AlipayChinareModelResult Result { get; set; }
    }
}
