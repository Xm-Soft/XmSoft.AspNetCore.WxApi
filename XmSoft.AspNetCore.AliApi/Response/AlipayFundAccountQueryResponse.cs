using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayFundAccountQueryResponse.
    /// </summary>
    public class AlipayFundAccountQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 可用余额。可用于支付或提现的余额。
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }
    }
}
