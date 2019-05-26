using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingSendResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingSendResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝－中小学－教育缴费的账单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
