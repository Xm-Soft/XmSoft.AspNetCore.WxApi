using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsAutoServiceCouponVerifyResponse.
    /// </summary>
    public class AlipayInsAutoServiceCouponVerifyResponse : AliApiResponse
    {
        /// <summary>
        /// 核销同步结果，返回成功或失败。
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
