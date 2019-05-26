using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineAnswerPushResponse.
    /// </summary>
    public class AlipayEcoMycarDialogonlineAnswerPushResponse : AliApiResponse
    {
        /// <summary>
        /// 技师ID，支付宝对技师的唯一标识
        /// </summary>
        [XmlElement("answer_id")]
        public string AnswerId { get; set; }
    }
}
