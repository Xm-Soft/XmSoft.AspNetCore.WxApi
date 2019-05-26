using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyApplyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [XmlElement("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [XmlElement("quote_biz_id")]
        public string QuoteBizId { get; set; }

        /// <summary>
        /// 车险订单交易信息
        /// </summary>
        [XmlArray("trade_infos")]
        [XmlArrayItem("ins_trade_info")]
        public List<InsTradeInfo> TradeInfos { get; set; }

        /// <summary>
        /// 吱口令
        /// </summary>
        [XmlElement("zhi_link")]
        public string ZhiLink { get; set; }
    }
}
