using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceLoanApplyResponse.
    /// </summary>
    public class AlipayCreditAutofinanceLoanApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 汽车金融内部订单号
        /// </summary>
        [XmlElement("applyno")]
        public string Applyno { get; set; }

        /// <summary>
        /// 是否需要引导认证
        /// </summary>
        [XmlElement("needauth")]
        public bool Needauth { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("outorderno")]
        public string Outorderno { get; set; }
    }
}
