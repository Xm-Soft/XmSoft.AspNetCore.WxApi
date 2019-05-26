using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditGuaranteeTradedrivePayResponse.
    /// </summary>
    public class MybankCreditGuaranteeTradedrivePayResponse : AliApiResponse
    {
        /// <summary>
        /// 调用成功则返回调用业务编码
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
