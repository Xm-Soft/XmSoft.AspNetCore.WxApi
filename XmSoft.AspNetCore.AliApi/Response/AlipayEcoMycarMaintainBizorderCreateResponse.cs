using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainBizorderCreateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainBizorderCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 业务订单编号，规则28位；
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
