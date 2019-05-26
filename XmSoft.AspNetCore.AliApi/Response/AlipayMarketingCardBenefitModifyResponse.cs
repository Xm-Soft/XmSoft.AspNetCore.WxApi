using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitModifyResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 权益修改结果；true成功：false失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
