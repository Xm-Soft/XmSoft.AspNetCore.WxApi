using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopApplyorderCancelResponse.
    /// </summary>
    public class AlipayOfflineMarketShopApplyorderCancelResponse : AliApiResponse
    {
        /// <summary>
        /// 申请撤销成功接口同步返回的支付宝申请流水号。
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
