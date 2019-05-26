using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberDeleteResponse.
    /// </summary>
    public class AlipaySocialBaseChatGmemberDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 删除结果
        /// </summary>
        [XmlElement("result_delete")]
        public bool ResultDelete { get; set; }
    }
}
