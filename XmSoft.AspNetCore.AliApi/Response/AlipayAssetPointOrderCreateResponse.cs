using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayAssetPointOrderCreateResponse.
    /// </summary>
    public class AlipayAssetPointOrderCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝集分宝发放流水号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }
    }
}
