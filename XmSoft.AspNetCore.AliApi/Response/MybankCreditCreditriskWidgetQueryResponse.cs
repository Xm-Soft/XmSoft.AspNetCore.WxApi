using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditCreditriskWidgetQueryResponse.
    /// </summary>
    public class MybankCreditCreditriskWidgetQueryResponse : AliApiResponse
    {
        /// <summary>
        /// widget json数据
        /// </summary>
        [XmlElement("widgetjson")]
        public string Widgetjson { get; set; }
    }
}
