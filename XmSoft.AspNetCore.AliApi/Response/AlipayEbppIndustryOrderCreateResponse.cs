using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppIndustryOrderCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryOrderCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 扩展属性，json串(key-value对)
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 支付宝的业务订单号，具有唯一性。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
