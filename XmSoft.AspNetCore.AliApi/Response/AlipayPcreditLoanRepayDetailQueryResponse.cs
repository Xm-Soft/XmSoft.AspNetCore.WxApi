using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditLoanRepayDetailQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanRepayDetailQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 还款流水明细列表
        /// </summary>
        [XmlArray("repay_detail_list")]
        [XmlArrayItem("repay_detail_v_o")]
        public List<RepayDetailVO> RepayDetailList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
