using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditCreditriskGuarschemeQueryResponse.
    /// </summary>
    public class MybankCreditCreditriskGuarschemeQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 可用担保额度
        /// </summary>
        [XmlElement("available_amt")]
        public string AvailableAmt { get; set; }
    }
}
