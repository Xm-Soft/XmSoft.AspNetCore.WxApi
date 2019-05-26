using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGnameModifyResponse.
    /// </summary>
    public class AlipaySocialBaseChatGnameModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("result_modify")]
        public bool ResultModify { get; set; }
    }
}
