using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserTradeSearchResponse.
    /// </summary>
    public class AlipayUserTradeSearchResponse : AliApiResponse
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
        public string TotalResults { get; set; }

        /// <summary>
        /// 交易记录列表
        /// </summary>
        [XmlArray("trade_records")]
        [XmlArrayItem("trade_record")]
        public List<TradeRecord> TradeRecords { get; set; }
    }
}
