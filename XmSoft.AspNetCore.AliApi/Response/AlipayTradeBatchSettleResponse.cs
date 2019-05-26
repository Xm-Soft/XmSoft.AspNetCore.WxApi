using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayTradeBatchSettleResponse.
    /// </summary>
    public class AlipayTradeBatchSettleResponse : AliApiResponse
    {
        /// <summary>
        /// 结算受理时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 业务结果码。    ACCEPT_SUCCESS：受理成功；  ACCEPT_FAIL：受理失败；  SUCCESS：结算处理成功；  FAIL：结算处理失败；  SYSTEM_EXCEPTION：系统异常
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结算单据号
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }
    }
}
