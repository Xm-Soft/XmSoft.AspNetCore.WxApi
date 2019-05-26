using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGnoticeModifyResponse.
    /// </summary>
    public class AlipaySocialBaseChatGnoticeModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("result_modify")]
        public string ResultModify { get; set; }
    }
}
