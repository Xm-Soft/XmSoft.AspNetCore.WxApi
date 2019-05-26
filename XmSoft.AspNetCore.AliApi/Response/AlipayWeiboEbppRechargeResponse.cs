using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayWeiboEbppRechargeResponse.
    /// </summary>
    public class AlipayWeiboEbppRechargeResponse : AliApiResponse
    {
        /// <summary>
        /// 返回缴费页面
        /// </summary>
        [XmlElement("partnerpuccharge")]
        public string Partnerpuccharge { get; set; }
    }
}
