using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditProdarrangementContracttextQueryResponse.
    /// </summary>
    public class MybankCreditProdarrangementContracttextQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 合同内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
