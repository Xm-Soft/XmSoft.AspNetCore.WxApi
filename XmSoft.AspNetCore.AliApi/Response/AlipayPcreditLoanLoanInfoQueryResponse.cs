using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditLoanLoanInfoQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanLoanInfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 贷款记录列表
        /// </summary>
        [XmlArray("base_apply_list")]
        [XmlArrayItem("base_loan_apply_v_o")]
        public List<BaseLoanApplyVO> BaseApplyList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
