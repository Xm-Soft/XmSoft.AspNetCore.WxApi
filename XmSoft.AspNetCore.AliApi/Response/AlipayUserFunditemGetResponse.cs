using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserFunditemGetResponse.
    /// </summary>
    public class AlipayUserFunditemGetResponse : AliApiResponse
    {
        /// <summary>
        /// 查询得到的消费记录详细信息（主记录+资金明细列表）
        /// </summary>
        [XmlElement("fund_detail_item_AliApimodel")]
        public FundDetailItemAliApiModel FundDetailItemAliApimodel { get; set; }
    }
}
