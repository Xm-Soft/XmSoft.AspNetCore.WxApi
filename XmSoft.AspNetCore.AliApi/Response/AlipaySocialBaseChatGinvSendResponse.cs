using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGinvSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatGinvSendResponse : AliApiResponse
    {
        /// <summary>
        /// 结果提示信息
        /// </summary>
        [XmlElement("result_tip")]
        public string ResultTip { get; set; }
    }
}
