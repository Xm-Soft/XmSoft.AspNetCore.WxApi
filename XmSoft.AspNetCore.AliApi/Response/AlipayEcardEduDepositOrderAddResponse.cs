using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcardEduDepositOrderAddResponse.
    /// </summary>
    public class AlipayEcardEduDepositOrderAddResponse : AliApiResponse
    {
        /// <summary>
        /// 支付申请流水号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
