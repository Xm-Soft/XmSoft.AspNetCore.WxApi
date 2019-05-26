using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCardDeleteResponse.
    /// </summary>
    public class AlipayMarketingCardDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝端删卡业务流水号
        /// </summary>
        [XmlElement("biz_serial_no")]
        public string BizSerialNo { get; set; }
    }
}
